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
        _crypto.GenerateTransientKey(out Guid keyId, out string x509pub);
        return Ok(new MPCryptoKey(keyId, x509pub));
    }

    [HttpPost("login")]
    [Produces("application/json")]
    public async Task<ActionResult<GameAvatarInfoDto>> Login([FromBody] MPServerMessageDto request)
    {
        if (! VerifyMPTimestamp(request.Timestamp)) {
            return BadRequest("Timestamp invalid");
        }
        
        var timestampedPayload = $"{request.Payload}.{request.Timestamp.ToString()}";
        if (! _crypto.VerifyMPSignature(timestampedPayload, request.Signature)) {
            return BadRequest("Signature invalid");
        }
        
        var data = _crypto.TransientKeyDecrypt(request.KeyId, Convert.FromBase64String(request.Payload));
        if (data is null || data.Length == 0) {
            return StatusCode(500);
        }

        var loginRequest = JsonSerializer.Deserialize<UserLoginDto>(
                Encoding.UTF8.GetString(data),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        if (loginRequest is null || loginRequest.Username is null || loginRequest.Password is null) {
            return BadRequest("Login request body malformed");
        }

        var user = _context.Users
            .Where(u => u.Username.ToLower() == loginRequest.Username.ToLower())
            .Include(u => u.GameAvatar)
            .FirstOrDefault();
        if (user is null) {
            return BadRequest("Username/Email or Password invalid");
        }
        if (! _crypto.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt)) {
            return BadRequest("Username/Email or Password invalid");
        }

        GameAvatar gameAvatar;
        if (user.GameAvatar is null)
        {
            gameAvatar = new GameAvatar() { UserId = user.Id };
            user.GameAvatar = gameAvatar;
            _context.Entry(user).State = EntityState.Modified;
            _context.Add<GameAvatar>(gameAvatar);
            _context.SaveChanges();
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

    private bool VerifyMPTimestamp(int epochSeconds)
    {
        var utcTimestamp = DateTimeOffset.FromUnixTimeSeconds(epochSeconds);
        var seconds = (DateTimeOffset.UtcNow - utcTimestamp).TotalSeconds;
        return 0 < seconds && seconds <= _payloadMaxAge;
    }
}