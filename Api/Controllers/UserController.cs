using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data;
using SharpScape.Api.Models;
using SharpScape.Shared.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SharpScape.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<List<UserInfoDto>>> Get()
        {
            var users = await _context.Users.Select(user => new UserInfoDto().FromUser(user)).ToListAsync();

            return Ok(users);
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

            return Ok(userinfo);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IActionResult> UpdateUser(int id,[FromBody] UserRegisterDto value)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
            {
                return NotFound();
            }
            var newuser = new User(value.Username, value.Email, value.Password);
            user.Email = newuser.Email;
            user.Username = newuser.Username;
            user.PasswordHash = newuser.PasswordHash;
            user.PasswordSalt = newuser.PasswordSalt;
            _context.Entry(user).State=EntityState.Modified;
            try { await _context.SaveChangesAsync(); }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExist(id))
                {
                    return NotFound();
                }
                throw;
            }
            return NoContent();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user is null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [Authorize(Roles="Admin")]
        [HttpPut("UpdateRole")]
        public async Task<IActionResult> UpdateRole(int id, string role)
        {
            var user=await _context.Users.FindAsync(id);
            if(user is null)
                return NotFound();
            user.Role = role;
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
