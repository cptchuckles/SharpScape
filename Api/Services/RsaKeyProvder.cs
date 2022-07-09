using System.Security.Cryptography;

namespace SharpScape.Api.Services;

public class RsaKeyProvider
{
    private Dictionary<Guid, byte[]> _transientSecrets = new();
    public void GetNewTransientKey(out Guid keyId, out string x509pub)
    {
        using (var rsa = new RSACryptoServiceProvider(1024))
        {
            keyId = Guid.NewGuid();
            x509pub = Convert.ToBase64String(rsa.ExportSubjectPublicKeyInfo());
            var secret = rsa.ExportRSAPrivateKey();
            _transientSecrets.Add(keyId, secret);
        }
    }
    public byte[]? CheckoutTransientSecret(Guid keyId)
    {
        if (! _transientSecrets.ContainsKey(keyId))
        {
            return null;
        }
        var secret = (byte[]) _transientSecrets[keyId]!;
        _transientSecrets.Remove(keyId);
        return secret;
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