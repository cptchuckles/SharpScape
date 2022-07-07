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
    private RsaKeyProvider _rsaKeyProvider;
    public Crypto(IConfiguration configuration, RsaKeyProvider rsaKeyProvider)
    {
        _configuration = configuration;
        _rsaKeyProvider = rsaKeyProvider;
    }

    public void GenerateTransientKey(out Guid keyId, out string x509pub)
    {
        using (var rsa = new RSACryptoServiceProvider(512))
        {
            keyId = Guid.NewGuid();
            x509pub = Convert.ToBase64String(rsa.ExportSubjectPublicKeyInfo());
            var secret = rsa.ExportRSAPrivateKey();
            _rsaKeyProvider.StoreTransientSecret(keyId, secret);
        }
    }

    public byte[]? TransientKeyDecrypt(Guid keyId, byte[] payload)
    {
        _rsaKeyProvider.CheckoutTransientSecret(keyId, out byte[]? secret);
        if (secret is null)
        {
            return null;
        }

        byte[]? data = null;
        try
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportRSAPrivateKey(secret, out int _);
                data = rsa.Decrypt(payload, false);
            }
        }
        catch (CryptographicException)
        {
            return null;
        }
        return data;
    }

    public string CreateToken(User user)
    {
        var claims = new List<Claim> {
            new Claim("Id", user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username +"," + user.Id.ToString()),
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

    public string CreateRefreshToken(User user)
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
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: cred);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

    public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512(passwordSalt))
        {
            var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return CryptographicOperations.FixedTimeEquals(computeHash, passwordHash);
        }
    }

    public bool VerifyMPSignature(string data, string signature)
    {
        return _rsaKeyProvider.MPServerPublicKey.VerifyHash(
            SHA256.HashData(Encoding.UTF8.GetBytes(data.TrimEnd())),
            Convert.FromBase64String(signature),
            HashAlgorithmName.SHA256,
            RSASignaturePadding.Pkcs1);
    }
}