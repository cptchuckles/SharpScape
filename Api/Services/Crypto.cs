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

    public byte[]? RsaDecrypt(byte[] key, byte[] payload)
    {
        try
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportRSAPrivateKey(key, out int _);
                return rsa.Decrypt(payload, false);
            }
        }
        catch (CryptographicException)
        {
            return null;
        }
    }

    public byte[]? AesDecrypt(byte[] key, byte[] secureData)
    {
        try
        {
            using (var aes = Aes.Create())
            {
                byte[] iv = new byte[aes.IV.Length];
                byte[] payload = new byte[secureData.Length - iv.Length];

                System.Buffer.BlockCopy(secureData, 0, iv, 0, iv.Length);
                System.Buffer.BlockCopy(secureData, iv.Length, payload, 0, payload.Length);

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(key, iv), CryptoStreamMode.Write))
                    {
                        cs.Write(payload, 0, payload.Length);
                    }
                    return ms.ToArray();
                }
            }
        }
        catch (CryptographicException)
        {
            return null;
        }
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
            return CryptographicOperations.FixedTimeEquals(computeHash, passwordHash);
        }
    }

    public bool VerifyMPSignature(string data, string signature)
    {
        try
        {
            return _rsaKeyProvider.MPServerPublicKey.VerifyHash(
                SHA256.HashData(Encoding.UTF8.GetBytes(data.TrimEnd())),
                Convert.FromBase64String(signature),
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1);
        }
        catch (Exception)
        {
            return false;
        }
    }
}