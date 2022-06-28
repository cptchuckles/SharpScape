using System.Security.Cryptography;

namespace SharpScape.Api.Services;

public class RsaKeyProvider : IRsaKeyProvider
{
    public RSA PublicKey { get; set; } = RSA.Create();
    public RSA PrivateKey { get; set; } = RSA.Create();
    public RSA MPServerPublicKey { get; set; } = RSA.Create();

    public RsaKeyProvider(IConfiguration config)
    {
        PublicKey.ImportFromPem(File.ReadAllText(config.GetSection("Jwt:RSA:PublicKey").Value));
        PrivateKey.ImportFromPem(File.ReadAllText(config.GetSection("Jwt:RSA:PrivateKey").Value));
        MPServerPublicKey.ImportFromPem(File.ReadAllText(config.GetSection("MPServer:RSA:PublicKey").Value));
    }
}