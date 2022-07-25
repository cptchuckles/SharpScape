using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data;
using SharpScape.Api.Data.Models;
using SharpScape.Api.Services;

namespace SharpScape.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly Crypto _crypto;
        private readonly ITokenService _tokenService;
        public TokenController(AppDbContext userContext, Crypto crypto, ITokenService tokenService)
        {
            this._context = userContext ?? throw new ArgumentNullException(nameof(userContext));
            this._crypto = crypto;
            this._tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));
        }


        [HttpPost]
        [Route("refresh")]
        public async Task<IActionResult> RefreshAsync(TokenApiModel tokenApiModel)
        {
            if (tokenApiModel is null)
                return BadRequest("Invalid client request");
            // string accessToken = tokenApiModel.AccessToken;
            string refreshToken = tokenApiModel.RefreshToken;

            var principal = _tokenService.GetPrincipalFromExpiredToken(refreshToken);
            var username = principal.Identity.Name; //this is mapped to the Name claim by default

            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);


            if (user == null)
                return BadRequest("no user");
            if (user.RefreshToken != refreshToken)
                return BadRequest("something wrong with refresh token");
            if (user.RefreshTokenExpiryTime <= DateTime.Now)
                return BadRequest(user.RefreshTokenExpiryTime);

            var newAccessToken = _crypto.CreateToken(user);
            //var newRefreshToken = _crypto.CreateRefreshToken(user);

            await _context.SaveChangesAsync();
            return Ok(new AuthenticatedResponse()
            {
                AccessToken = newAccessToken,
                RefreshToken = tokenApiModel.RefreshToken
            });
        }


        [HttpPost, Authorize]
        [Route("revoke")]
        public async Task<IActionResult> RevokeAsync()
        {
            var username = User.Identity.Name;
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);
            if (user == null) return BadRequest();
            user.RefreshToken = null;
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
