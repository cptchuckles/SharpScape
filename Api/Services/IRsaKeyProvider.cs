using System.Security.Cryptography;

namespace SharpScape.Api.Services;

public interface IRsaKeyProvider
{
    public RSA PublicKey { get; set; }
    public RSA PrivateKey { get; set; }
    public RSA MPServerPublicKey { get; set; }
}