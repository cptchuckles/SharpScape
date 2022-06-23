namespace SharpScape.Shared.Dto;

public class MPServerLoginDto
{
    public string TimestampedPayload { get; set; }
    public string Base64Signature { get; set; }
}