using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data;
using SharpScape.Api.Models;
using SharpScape.Shared.Dto;
using Microsoft.AspNetCore.Authorization;


namespace SharpScape.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumPostsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ForumPostsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ForumPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ForumPostDto>> GetForumPost(int id)
        {
            if (_context.ForumPosts == null)
            {
                return NotFound();
            }
            var fp = await _context.ForumPosts.FindAsync(id);

            if (fp == null)
            {
                return NotFound();
            }

            return new ForumPostDto()
            {
                Id = fp.Id,
                AuthorId = fp.AuthorId,
                Body = fp.Body,
                Created = fp.Created,
                ThreadId = fp.ThreadId
            };
        }



        // GET: api/Threads/5
        [HttpGet("Thread{id}")]
        public async Task<ActionResult<List<ForumPostDto>>> GetForumThreadbyCategory(int id)
        {
            if (_context.ForumPosts == null)
            {
                return NotFound();
            }
            var fpl = await _context.ForumPosts.Where(x => x.ThreadId == id).ToListAsync();

            List<ForumPostDto> forumPostDtos = new List<ForumPostDto>();
            foreach (var fp in fpl)
            {
                forumPostDtos.Add(new ForumPostDto()
                {
                    Id = fp.Id,
                    AuthorId = fp.AuthorId,
                    Body = fp.Body,
                    Created = fp.Created,
                    ThreadId = fp.ThreadId
                });


            }
            return forumPostDtos;
        }

        // GET: api/Threads/5
        [HttpGet("User{id}")]
        public async Task<ActionResult<List<ForumPostDto>>> GetForumPostbyUserId(int id)
        {
            if (_context.ForumPosts == null)
            {
                return NotFound();
            }
            var fpl = await _context.ForumPosts.Where(x => x.AuthorId == id).ToListAsync();
            List<ForumPostDto> forumPostDtos = new List<ForumPostDto>();
            foreach (var fp in fpl)
            {
                forumPostDtos.Add(new ForumPostDto()
                {
                    Id = fp.Id,
                    AuthorId = fp.AuthorId,
                    Body = fp.Body,
                    Created = fp.Created,
                    ThreadId = fp.ThreadId
                });
            }
            return forumPostDtos;
        }


        // POST: api/ForumPosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ForumPostDto>> PostForumPost(ForumPostDto fp)
        {
            if (_context.ForumPosts == null)
            {
                return Problem("Entity set 'AppDbContext.ForumPosts'  is null.");
            }
            _context.ForumPosts.Add(new ForumPost()
            {
                Id = fp.Id,
                AuthorId = fp.AuthorId,
                Body = fp.Body,
                ThreadId = fp.ThreadId
            });
            await _context.SaveChangesAsync();

            var fpl = await _context.ForumPosts.Where(x => x.ThreadId == fp.ThreadId).ToListAsync();

            List<ForumPostDto> forumPostDtos = new List<ForumPostDto>();
            foreach (var forumPost in fpl)
            {
                forumPostDtos.Add(new ForumPostDto()
                {
                    Id = forumPost.Id,
                    AuthorId = forumPost.AuthorId,
                    Body = forumPost.Body,
                    Created = forumPost.Created,
                    ThreadId = forumPost.ThreadId
                });
            }
            return Ok(forumPostDtos);
        }
        [Authorize(Roles = "Admin,User")]
        [HttpPost("{id}")]
        public async Task<IActionResult> UpdatePost(int id, [FromBody] ForumPostEditDto request)
        {
            var UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value);
            var role = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role")?.Value;
            var post = await _context.ForumPosts.FindAsync(id);
            if (post is null)
            {
                return NotFound();
            }
            if (post.AuthorId == UserId || String.Equals(role, "Admin"))
            {
                post.Body = request.Body;
                await _context.SaveChangesAsync();
                return Ok(post);
            }
            return BadRequest("You cannot edit other people's post");
        }
        // DELETE: api/ForumPosts/5
        [Authorize(Roles = "Admin,User")]
        [HttpDelete("{id}")]
        // its author or user with admin role can detele a post
        public async Task<IActionResult> DeleteForumPost(int id)
        {
            var UserId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value);
            var role = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role")?.Value;
            var post = await _context.ForumPosts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            if (post.AuthorId == UserId || String.Equals(role, "Admin"))
            {
                _context.ForumPosts.Remove(post);
                await _context.SaveChangesAsync();
                return Ok("Successfully Removed post from database");
            }
            return BadRequest("You cannot delete other people's post");
        }

        private bool ForumPostExists(int id)
        {
            return (_context.ForumPosts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
