using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharpScape.Api.Data;
using SharpScape.Api.Models;
using SharpScape.Api.Services;
using SharpScape.Shared.Dto;

namespace SharpScape.Api.Controllers;

[ApiController]
[Route("api/game")]
public class MPServerController : ControllerBase
{
    private readonly IRsaKeyProvider _rsaKeyProvider;
    private readonly Crypto _crypto;
    private readonly AppDbContext _context;

    private double _payloadMaxAge;

    public MPServerController(IRsaKeyProvider rsaKeyProvider, Crypto crypto, IConfiguration config, AppDbContext context)
    {
        _rsaKeyProvider = rsaKeyProvider;
        _crypto = crypto;
        _context = context;

        _payloadMaxAge = config.GetValue<int>("MPServer:PayloadMaxAge");
    }

    [HttpPost("login")]
    [Produces("application/json")]
    public async Task<ActionResult<GameAvatarInfoDto>> Login([FromBody] MPServerMessageDto request)
    {
        if (! VerifyMPTimestamp(request.Timestamp)) {
            return BadRequest();
        }
        
        var timestampedPayload = $"{request.Payload}.{request.Timestamp.ToString()}";
        if (! VerifyMPSignature(timestampedPayload, request.Signature)) {
            return BadRequest();
        }
        
        var data = _rsaKeyProvider.PrivateKey.Decrypt(Convert.FromBase64String(request.Payload), RSAEncryptionPadding.Pkcs1);
        if (data is null || data.Length == 0) {
            return BadRequest("Verified payload was malformed: could not decrypt");
        }

        var loginRequest = JsonSerializer.Deserialize<UserLoginDto>(
                Encoding.UTF8.GetString(data),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        if (loginRequest is null || loginRequest.Username is null || loginRequest.Password is null) {
            return BadRequest("Verified payload was malformed: could not parse JSON");
        }

        var user = _context.Users.FirstOrDefault(u => u.Username.ToLower() == loginRequest.Username.ToLower());
        if (user is null) {
            return BadRequest("Username/Email or Password incorrect");
        }
        
        if (! _crypto.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt)) {
            return BadRequest("Username/Email or Password incorrect");
        }

        return Ok(new GameAvatarInfoDto() {
            UserInfo = new UserInfoDto().FromUser(user),
            Avatar = "Whatever", // TODO: Make models for avatars and stuff
            GlobalPositionX = 47,
            GlobalPositionY = 92
        });
    }

    private bool VerifyMPSignature(string data, string signature)
    {
        return _rsaKeyProvider.MPServerPublicKey.VerifyHash(
            SHA256.HashData(Encoding.UTF8.GetBytes(data.TrimEnd())),
            Convert.FromBase64String(signature),
            HashAlgorithmName.SHA256,
            RSASignaturePadding.Pkcs1);
    }

    private bool VerifyMPTimestamp(int epochSeconds)
    {
        var utcTimestamp = DateTimeOffset.FromUnixTimeSeconds(epochSeconds);
        var seconds = (DateTimeOffset.UtcNow - utcTimestamp).TotalSeconds;
        return 0 < seconds && seconds <= _payloadMaxAge;
    }
}