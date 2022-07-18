using System.Security.Claims;

namespace SharpScape.Website.Services;

public interface IAuthTokenProvider
{
    public string? Token { get; set; }
    public ClaimsIdentity? GetClaims();
    public string? RefreshToken { get; set; }
}

public class AuthTokenProvider : IAuthTokenProvider
{
    public ClaimsIdentity? GetClaims()
    {
        return new ClaimsIdentity(AppAuthStateProvider.ParseClaimsFromJwt(Token), "jwt");
    }

    public string? Token { get; set; }
    public string? RefreshToken { get; set; }

    public AuthTokenProvider()
    {
    }
}