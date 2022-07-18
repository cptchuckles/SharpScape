using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SharpScape.Api.Models;
using SharpScape.Api.Data;
using SharpScape.Shared.Dto;
using SharpScape.Api.Services;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace SharpScape.Api.Controllers;

[ApiController]
[Route("api/")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly Crypto _crypto;
    private readonly ITokenService _tokenService;

    public AuthController(AppDbContext context, Crypto crypto, ITokenService tokenService)
    {
        _context = context;
        _crypto = crypto;
        _tokenService = tokenService ?? throw new ArgumentNullException(nameof(tokenService));
    }

    [AllowAnonymous]
    [HttpPost("Register")]
    public ActionResult<string> Register([FromBody] UserRegisterDto request)
    {
        if (_context.Users.Any(u => u.Email.ToLower() == request.Email.ToLower()))
            return BadRequest($"User with email {request.Email} already exists");
        if (_context.Users.Any(u => u.Username.ToLower() == request.Username.ToLower()))
            return BadRequest($"Username {request.Username} already exists");

        var user = new User(request.Username, request.Email, request.Password);
        _context.Add(user);
        _context.SaveChanges();

        return Ok(_crypto.CreateToken(user));
    }
    [Authorize(Roles="Admin")]
    [HttpPost("RegisterAdmin")]
    public ActionResult<string> RegisterAdmin([FromBody] UserRegisterDto request)
    {
        if (_context.Users.Any(u => u.Email.ToLower() == request.Email.ToLower()))
            return BadRequest($"User with email {request.Email} already exists");
        if (_context.Users.Any(u => u.Username.ToLower() == request.Username.ToLower()))
            return BadRequest($"Username {request.Username} already exists");

        var user = new User(request.Username, request.Email, request.Password, UserRole.Admin);
        _context.Add(user);
        _context.SaveChanges();

        return Ok(_crypto.CreateToken(user));
    }

    [AllowAnonymous]
    [HttpPost("Login")]
    public async Task<ActionResult<string>> Login([FromBody] UserLoginDto request)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Username.ToLower() == request.Username.ToLower());

        if (user is null)
            return BadRequest("Username/Email or Password incorrect");

        if (user.Banned.HasValue)
        {
            if (user.IsBanned())
            {
                return StatusCode(401, "Oh no! you are banned till " + user.Banned);
            }
            else
            {
                user.Banned = null;
                await _context.SaveChangesAsync();
            }
        }
        
        if (! _crypto.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            return BadRequest("Username/Email or Password incorrect");

        //Create the Acess Token and Refresh Token
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, "Manager")
        };

        UserLoginResponseDto response = new UserLoginResponseDto();

        response.accessToken = _crypto.CreateToken(user);
        response.refreshToken = _crypto.CreateRefreshToken(user);
        response.Id = user.Id;
        response.Username = user.Username;

        user.RefreshToken = response.refreshToken;
        user.RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(30);

        _context.Users.Update(user);

        await _context.SaveChangesAsync();
        return Ok(response);
    }
}