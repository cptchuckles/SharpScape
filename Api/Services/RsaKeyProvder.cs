using System.Security.Cryptography;

namespace SharpScape.Api.Services;

public class RsaKeyProvider : IRsaKeyProvider
{
    public RSA PublicKey { get; set; } = RSA.Create();
    public RSA PrivateKey { get; set; } = RSA.Create();

    public RsaKeyProvider()
    {
    }
}