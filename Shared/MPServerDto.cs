namespace SharpScape.Shared.Dto;

public class MPServerMessageDto
{
    public Guid KeyId { get; set; }
    public string Payload { get; set; }
    public int Timestamp { get; set; }
    public string Signature { get; set; }
}

public class GameAvatarInfoDto
{
    public UserInfoDto UserInfo { get; set; }
    public string SpriteName { get; set; }
    public float GlobalPositionX { get; set; }
    public float GlobalPositionY { get; set; }
}

public class MPCryptoKey
{
    public Guid KeyId { get; set; }
    public string X509Pub { get; set; }
    public MPCryptoKey(Guid keyId, string x509pub)
    {
        KeyId = keyId;
        X509Pub = x509pub;
    }
}