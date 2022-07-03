using System.Security.Cryptography;

namespace SharpScape.Api.Services;

public class RsaKeyProvider
{
    public string PublicKeyPem { get; set; }
    public RSA PublicKey { get; set; } = RSA.Create();
    public RSA PrivateKey { get; set; } = RSA.Create();
    public RSA MPServerPublicKey { get; set; } = RSA.Create();

    public RsaKeyProvider(IConfiguration config)
    {
        PublicKeyPem = File.ReadAllText(config.GetSection("Jwt:RSA:PublicKey").Value);
        PublicKey.ImportFromPem(PublicKeyPem);
        PrivateKey.ImportFromPem(File.ReadAllText(config.GetSection("Jwt:RSA:PrivateKey").Value));
        MPServerPublicKey.ImportFromPem(File.ReadAllText(config.GetSection("MPServer:RSA:PublicKey").Value));
    }
}