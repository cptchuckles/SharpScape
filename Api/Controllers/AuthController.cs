using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SharpScape.Api.Models;
using SharpScape.Api.Data;
using SharpScape.Shared.Dto;
using SharpScape.Api.Services;
using System.Security.Claims;
using SharpScape.Api.Data.Models;

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
    public ActionResult<string> Login([FromBody] UserLoginDto request)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username.ToLower() == request.Username.ToLower());
        if(user.Banned.HasValue){
            DateTime dt = user.Banned.Value; 
            int result = DateTime.Compare(dt,DateTime.Now.ToUniversalTime());
            if(result > 0)
            {
                return StatusCode(500,"Oh no! you are banned till " + user.Banned);
            }else{
                user.Banned = null;
                _context.SaveChanges();
            }
        }
        UserLoginResponseDto response = new UserLoginResponseDto();
        if (user is null)
            return BadRequest("Username/Email or Password incorrect");
        
        if (! _crypto.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            return BadRequest("Username/Email or Password incorrect");

        //Create the Acess Token and Refresh Token
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, "Manager")
        };


        

        //return Ok(new AuthenticatedResponse
        //{
        //    AccessToken = accessToken,
        //    RefreshToken = refreshToken
        //});


        //return Ok(_crypto.CreateToken(user));

        response.accessToken = _crypto.CreateToken(user);
        response.refreshToken = _crypto.CreateRefreshToken(user);
        response.Id = user.Id;
        response.Username = user.Username;

        user.RefreshToken = response.refreshToken;
        user.RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(30);

        _context.Users.Update(user);

        _context.SaveChanges();
        return Ok(response);
    }
}