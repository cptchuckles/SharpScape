using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data;
using SharpScape.Api.Models;
using SharpScape.Api.Services;
using SharpScape.Shared.Dto;

namespace SharpScape.Api.Controllers;

[ApiController]
[Route("api/game")]
public class MPServerController : ControllerBase
{
    private readonly RsaKeyProvider _rsaKeyProvider;
    private readonly Crypto _crypto;
    private readonly AppDbContext _context;

    private double _payloadMaxAge;

    public MPServerController(RsaKeyProvider rsaKeyProvider, Crypto crypto, IConfiguration config, AppDbContext context)
    {
        _rsaKeyProvider = rsaKeyProvider;
        _crypto = crypto;
        _context = context;

        _payloadMaxAge = config.GetValue<int>("MPServer:PayloadMaxAge");
    }

    [HttpGet("transientkey")]
    [Produces("application/json")]
    public ActionResult<MPCryptoKey> GetPublicKey()
    {
        _rsaKeyProvider.GetNewTransientKey(out Guid keyId, out string x509pub);
        return Ok(new MPCryptoKey(keyId, x509pub));
    }

    [HttpPost("login")]
    [Produces("application/json", "text/plain")]
    public async Task<ActionResult<GameAvatarInfoDto>> Login([FromBody] MPServerMessageDto request)
    {
        if (! ValidateRequest(request)) {
            return BadRequest();
        }

        // Get the Unique Secret DTO from the request payload
        string json = Encoding.UTF8.GetString(Convert.FromBase64String(request.Payload));
        var uniqueSecret = JsonSerializer.Deserialize<MPUniqueSecret>(json);
        if (uniqueSecret is null) {
            return BadRequest("Request payload invalid");
        }

        // Get transient RSA private key by its id
        byte[]? rsaKey = _rsaKeyProvider.CheckoutTransientSecret(uniqueSecret.KeyId);
        if (rsaKey is null) {
            return BadRequest("Key not found");
        }
        
        // RSA Decrypt AES key
        byte[]? aesKey = _crypto.RsaDecrypt(rsaKey, Convert.FromBase64String(uniqueSecret.SecureKey));
        if (aesKey is null || aesKey.Length == 0) {
            return StatusCode(500);
        }

        // AES Decrypt login credentials
        byte[]? data = _crypto.AesDecrypt(aesKey, Convert.FromBase64String(uniqueSecret.Payload));
        if (data is null || data.Length == 0) {
            return BadRequest("Payload invalid");
        }

        // Parse login credentials
        var loginRequest = JsonSerializer.Deserialize<UserLoginDto>(
                Encoding.UTF8.GetString(data),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        if (loginRequest is null || loginRequest.Username is null || loginRequest.Password is null) {
            return BadRequest("Login request body malformed");
        }

        // Try login
        var user = await _context.Users.Where(u => u.Username.ToLower() == loginRequest.Username.ToLower())
                                       .Include(u => u.GameAvatar)
                                       .FirstOrDefaultAsync();
        if (user is null) {
            return BadRequest("Username/Email or Password invalid");
        }
        if (! _crypto.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt)) {
            return BadRequest("Username/Email or Password invalid");
        }

        // Ensure user has a GameAvatar
        GameAvatar gameAvatar;
        if (user.GameAvatar is null)
        {
            gameAvatar = new GameAvatar() { UserId = user.Id };
            user.GameAvatar = gameAvatar;
            _context.GameAvatars.Add(gameAvatar);
            _context.Entry<User>(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        else
        {
            gameAvatar = user.GameAvatar;
        }

        return Ok(new GameAvatarInfoDto() {
            UserInfo = new UserInfoDto().FromUser(user),
            SpriteName = gameAvatar.SpriteName,
            GlobalPositionX = gameAvatar.GlobalPositionX,
            GlobalPositionY = gameAvatar.GlobalPositionY
        });
    }

    [HttpPut("save")]
    public async Task<IActionResult> Save(MPServerMessageDto request)
    {
        if (! ValidateRequest(request)) {
            return BadRequest();
        }
        
        var saveInfo = JsonSerializer.Deserialize<GameSaveDto>(Encoding.UTF8.GetString(Convert.FromBase64String(request.Payload)));
        if (saveInfo is null) {
            return BadRequest("Couldn't parse request");
        }

        var user = await _context.Users.Where(u => u.Id == saveInfo.UserId)
                                       .Include(u => u.GameAvatar)
                                       .FirstOrDefaultAsync();
        if (user is null || user.GameAvatar is null) {
            return BadRequest("User or avatar not found");
        }

        user.GameAvatar.GlobalPositionX = saveInfo.GlobalPositionX;
        user.GameAvatar.GlobalPositionY = saveInfo.GlobalPositionY;
        _context.Entry<GameAvatar>(user.GameAvatar).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ValidateRequest(MPServerMessageDto request)
    {
        // Check timestamp
        if (! VerifyMPTimestamp(request.Timestamp)) {
            return false;
        }
        
        // Verify signature from MP Server
        var timestampedPayload = $"{request.Payload}.{request.Timestamp.ToString()}";
        if (! _crypto.VerifyMPSignature(timestampedPayload, request.Signature)) {
            return false;
        }

        return true;
    }

    private bool VerifyMPTimestamp(int epochSeconds)
    {
        var utcTimestamp = DateTimeOffset.FromUnixTimeSeconds(epochSeconds);
        var seconds = (DateTimeOffset.UtcNow - utcTimestamp).TotalSeconds;
        return 0 < seconds && seconds <= _payloadMaxAge;
    }
}