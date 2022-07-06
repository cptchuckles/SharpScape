using System.Security.Cryptography;

namespace SharpScape.Api.Services;

public class RsaKeyProvider
{
    private Dictionary<Guid, byte[]> _transientSecrets = new();
    public void StoreTransientSecret(Guid keyId, byte[] secret)
    {
        _transientSecrets.Add(keyId, secret);
    }
    public void CheckoutTransientSecret(Guid keyId, out byte[]? secret)
    {
        if (! _transientSecrets.ContainsKey(keyId))
        {
            secret = null;
            return;
        }
        secret = (byte[]) _transientSecrets[keyId]!;
        _transientSecrets.Remove(keyId);
    }

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