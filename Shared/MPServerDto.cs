namespace SharpScape.Shared.Dto;

public class MPServerMessageDto
{
    public string Payload { get; set; }
    public int Timestamp { get; set; }
    public string Signature { get; set; }
}

public class GameAvatarInfoDto
{
    // TODO: Make a robust model for this kind of shit
    public UserInfoDto UserInfo { get; set; }
    public string Avatar { get; set; }
    public float GlobalPositionX { get; set; }
    public float GlobalPositionY { get; set; }
}