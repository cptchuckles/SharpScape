namespace SharpScape.Website.Services;

public interface IAuthTokenProvider
{
    public string? Token { get; set; }
    public string? RefreshToken { get; set; }
}

public class AuthTokenProvider : IAuthTokenProvider
{
    public string? Token { get; set; }
    public string? RefreshToken { get; set; }
    public AuthTokenProvider()
    {
    }
}