using System.Text;
using System.Security.Cryptography;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SharpScape.Api.Models;
using SharpScape.Api.Data;
using SharpScape.Shared.Dto;
using SharpScape.Api.Services;

namespace SharpScape.Api.Controllers;

[ApiController]
[Route("api/")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IRsaKeyProvider _rsaKeyProvider;
    private readonly AppDbContext _context;

    public AuthController(IConfiguration configuration, IRsaKeyProvider rsaKeyProvider, AppDbContext context)
    {
        _configuration = configuration;
        _rsaKeyProvider = rsaKeyProvider;
        _context = context;
    }

    [AllowAnonymous]
    [HttpPost("Register")]
    public ActionResult<string> Register([FromBody] UserRegisterDto request)
    {
        if (_context.Users.Any(u => u.Email.ToLower() == request.Email.ToLower()))
            return BadRequest($"User with email {request.Email} already exists");
        if (_context.Users.Any(u => u.Username.ToLower() == request.Username.ToLower()))
            return BadRequest($"Username {request.Username} already exists");

        CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

        var user = new User() {
            Username = request.Username,
            Email = request.Email,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt
        };
        _context.Add(user);
        _context.SaveChanges();

        return Ok(CreateToken(user));
    }

    [AllowAnonymous]
    [HttpPost("Login")]
    public ActionResult<string> Login([FromBody] UserLoginDto request)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username.ToLower() == request.Username.ToLower());

        if (user is null)
            return BadRequest("Username/Email or Password incorrect");
        
        if (! VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            return BadRequest("Username/Email or Password incorrect");

        return Ok(CreateToken(user));
    }

    private string CreateToken(User user)
    {
        var claims = new List<Claim> {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, "NA")
        };

        var key = new RsaSecurityKey(_rsaKeyProvider.PrivateKey);
        var cred = new SigningCredentials(key, SecurityAlgorithms.RsaSha512);

        var token = new JwtSecurityToken(
            issuer: _configuration.GetSection("Jwt:Issuer").Value,
            audience: _configuration.GetSection("Jwt:Audience").Value,
            claims: claims,
            expires: DateTime.Now.AddMinutes(5),
            signingCredentials: cred);
        
        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }

    private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512(passwordSalt))
        {
            var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return computeHash.SequenceEqual(passwordHash);
        }
    }
}