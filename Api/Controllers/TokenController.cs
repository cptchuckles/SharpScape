﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly ITokenService _tokenService;
        public TokenController(AppDbContext userContext, ITokenService tokenService)
        {
            this._context = userContext ?? throw new ArgumentNullException(nameof(userContext));
            this._tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));
        }
        [HttpPost]
        [Route("refresh")]
        public IActionResult Refresh(TokenApiModel tokenApiModel)
        {
            if (tokenApiModel is null)
                return BadRequest("Invalid client request");
            // string accessToken = tokenApiModel.AccessToken;
            string refreshToken = tokenApiModel.RefreshToken;

            var principal = _tokenService.GetPrincipalFromExpiredToken(refreshToken);
            var username = principal.Identity.Name; //this is mapped to the Name claim by default

            var user = _context.Users.SingleOrDefault(u => u.Username == username);

            // if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            //     return BadRequest("Invalid client request");

            if (user == null)
                return BadRequest("no user");
            if (user.RefreshToken != refreshToken)
                return BadRequest("something wrong with refresh token");
            if (user.RefreshTokenExpiryTime <= DateTime.Now)
                return BadRequest(user.RefreshTokenExpiryTime);

            var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims);
            // var newRefreshToken = _tokenService.GenerateRefreshToken();

            // user.RefreshToken = newRefreshToken;
            _context.SaveChanges();
            return Ok(new AuthenticatedResponse()
            {
                AccessToken = newAccessToken,
                RefreshToken = refreshToken
            });
        }
        [HttpPost, Authorize]
        [Route("revoke")]
        public IActionResult Revoke()
        {
            var username = User.Identity.Name;
            var user = _context.Users.SingleOrDefault(u => u.Username == username);
            if (user == null) return BadRequest();
            user.RefreshToken = null;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
