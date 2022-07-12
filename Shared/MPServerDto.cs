namespace SharpScape.Shared.Dto;

public class MPServerMessageDto
{
    public string Payload { get; set; } = string.Empty;
    public int Timestamp { get; set; }
    public string Signature { get; set; } = string.Empty;
}

public class MPUniqueSecret
{
    public Guid KeyId { get; set; }
    public string SecureKey { get; set; } = string.Empty;
    public string Payload { get; set; } = string.Empty;
}

public class MPCryptoKey
{
    public Guid KeyId { get; set; }
    public string X509Pub { get; set; } = string.Empty;
    public MPCryptoKey(Guid keyId, string x509pub)
    {
        KeyId = keyId;
        X509Pub = x509pub;
    }
}

public class GameAvatarInfoDto
{
    public UserInfoDto UserInfo { get; set; }
    public string SpriteName { get; set; } = string.Empty;
    public float GlobalPositionX { get; set; }
    public float GlobalPositionY { get; set; }
}

public class GameSaveDto
{
    public int UserId { get; set; }
    public float GlobalPositionX { get; set; }
    public float GlobalPositionY { get; set; }
}