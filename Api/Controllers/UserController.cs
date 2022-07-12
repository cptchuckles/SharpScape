using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data;
using SharpScape.Api.Models;
using SharpScape.Shared.Dto;
using SharpScape.Api.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SharpScape.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        private readonly Crypto _crypto;
        public UserController(AppDbContext context, Crypto crypto)
        {
            _context = context;
            _crypto = crypto;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<List<UserInfoDto>>> Get()
        {
            // var users = await _context.Users.Select(user => new UserInfoDto().FromUser(user)).ToListAsync();
            var users = await _context.Users.ToListAsync();
            List<UserInfoDto> usersList = new List<UserInfoDto>();
            foreach (var user in users)
            {
                usersList.Add(new UserInfoDto()
                {
                    Id = user.Id,
                    Username = user.Username,
                    Email = user.Email,
                    Role = user.Role,
                    Created = user.Created,
                    ProfilePicDataUrl = user.ProfilePicDataUrl
                });
            }
            return Ok(usersList);

        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserInfoDto>> Get(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
            {
                return NotFound();
            }

            var userinfo = new UserInfoDto().FromUser(user);
            userinfo.ProfilePicDataUrl = user.ProfilePicDataUrl;
            return Ok(userinfo);
        }

        // POST api/<ValuesController>
        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserEditDto request)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
            {
                return NotFound();
            }
            if (!_crypto.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
                return BadRequest("Username/Email or Password incorrect");
            if (request.ProfilePicDataUrl != "")
            {
                user.ProfilePicDataUrl = request.ProfilePicDataUrl;
            }
            if (request.Username != "")
            {
                user.Username = request.Username;
            }
            if (request.Email != "")
            {
                user.Email = request.Email;
            }
            if (request.NewPassword != "")
            {
                var newuser = new User(request.Username, request.Email, request.NewPassword);
                user.PasswordHash = newuser.PasswordHash;
                user.PasswordSalt = newuser.PasswordSalt;
            }
            _context.Entry(user).State = EntityState.Modified;
            try { await _context.SaveChangesAsync(); }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExist(id))
                {
                    return NotFound();
                }
                throw;
            }
            UserInfoDto response = new UserInfoDto();
            response.Id = user.Id;
            response.Username = user.Username;
            response.Email = user.Email;
            response.Created = user.Created;
            response.ProfilePicDataUrl = user.ProfilePicDataUrl;
            return Ok(response);
        }
        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("UpdateRole")]
        public async Task<IActionResult> UpdateRole(int id, [FromBody] UserRoleDto request)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return NotFound();
            user.Role = request.Role;
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return Ok();
        }

        private bool UserExist(int id)
        {
            return _context.Users.Any(user => user.Id == id);
        }
    }
}
