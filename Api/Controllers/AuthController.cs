using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SharpScape.Api.Models;
using SharpScape.Api.Data;
using SharpScape.Shared.Dto;
using SharpScape.Api.Services;
using SharpScape.Shared.UserRole;

namespace SharpScape.Api.Controllers;

[ApiController]
[Route("api/")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly Crypto _crypto;

    public AuthController(AppDbContext context, Crypto crypto)
    {
        _context = context;
        _crypto = crypto;
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
    public ActionResult<string> RegisterAdim([FromBody] UserRegisterDto request)
    {
        if (_context.Users.Any(u => u.Email.ToLower() == request.Email.ToLower()))
            return BadRequest($"User with email {request.Email} already exists");
        if (_context.Users.Any(u => u.Username.ToLower() == request.Username.ToLower()))
            return BadRequest($"Username {request.Username} already exists");

        var user = new User(request.Username, request.Email, request.Password, UserRole.Role.Admin);
        _context.Add(user);
        _context.SaveChanges();

        return Ok(_crypto.CreateToken(user));
    }

    [AllowAnonymous]
    [HttpPost("Login")]
    public ActionResult<string> Login([FromBody] UserLoginDto request)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username.ToLower() == request.Username.ToLower());

        if (user is null)
            return BadRequest("Username/Email or Password incorrect");
        
        if (! _crypto.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            return BadRequest("Username/Email or Password incorrect");

        return Ok(_crypto.CreateToken(user));
    }
}