using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using SharpScape.Api.Models;

namespace SharpScape.Api.Services;

public class Crypto
{
    private IConfiguration _configuration;
    private IRsaKeyProvider _rsaKeyProvider;
    public Crypto(IConfiguration configuration, IRsaKeyProvider rsaKeyProvider)
    {
        _configuration = configuration;
        _rsaKeyProvider = rsaKeyProvider;
    }

    public string CreateToken(User user)
    {
        var claims = new List<Claim> {
            new Claim("Id", user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var key = new RsaSecurityKey(_rsaKeyProvider.PrivateKey);
        var cred = new SigningCredentials(key, SecurityAlgorithms.RsaSha512);

        var token = new JwtSecurityToken(
            issuer: _configuration.GetSection("Jwt:Issuer").Value,
            audience: _configuration.GetSection("Jwt:Audience").Value,
            claims: claims,
            expires: DateTime.Now.AddMinutes(5),
            signingCredentials: cred);
        
        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

    public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512(passwordSalt))
        {
            var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return computeHash.SequenceEqual(passwordHash);
        }
    }
}