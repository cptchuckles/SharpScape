using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SharpScape.Api.Services
{
    public class TokenService : ITokenService
    {
        private IConfiguration _configuration;
        private RsaKeyProvider _rsaKeyProvider;
        public TokenService(IConfiguration configuration, RsaKeyProvider rsaKeyProvider)
        {
            _configuration = configuration;
            _rsaKeyProvider = rsaKeyProvider;
        }

        //public string GenerateAccessToken(IEnumerable<Claim> claims)
        //{
        //    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
        //    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        //    var tokeOptions = new JwtSecurityToken(
        //        issuer: "https://localhost:5001",
        //        audience: "https://localhost:5001",
        //        claims: claims,
        //        expires: DateTime.Now.AddSeconds(5),
        //        signingCredentials: signinCredentials
        //    );
        //    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
        //    return tokenString;
        //}
        public string GenerateRefreshToken(IEnumerable<Claim> claims)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
                issuer: "https://localhost:5001",
                audience: "https://localhost:5001",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signinCredentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return tokenString;
        }
        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                ValidAlgorithms = _configuration.GetValue<string[]>("Jwt:Algorithms"),
                IssuerSigningKey = new RsaSecurityKey(_rsaKeyProvider.PublicKey),
                ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null)
                throw new SecurityTokenException("Invalid token");
            return principal;
        }
    }
}
