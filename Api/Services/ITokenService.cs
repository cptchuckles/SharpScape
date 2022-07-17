using System.Security.Claims;

namespace SharpScape.Api.Services
{
    public interface ITokenService
    {
        //string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken(IEnumerable<Claim> claims);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
