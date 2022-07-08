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
        // [Authorize]
        [HttpPost("{id}")]
        public async Task<IActionResult> UpdatePost(int id, [FromBody] ForumPostEditDto request)
        {
            var post = await _context.ForumPosts.FindAsync(id);
            if (post is null)
            {
                return BadRequest("There is no post");
            }
            if (post.AuthorId != request.UserId)
            {
                return BadRequest("You cannot edit other people's post");
            }
            post.Body = request.Body;
            await _context.SaveChangesAsync();
            return Ok(post);
        }
        // DELETE: api/ForumPosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForumPost(int id)
        {
            if (_context.ForumPosts == null)
            {
                return NotFound();
            }
            var forumPost = await _context.ForumPosts.FindAsync(id);
            if (forumPost == null)
            {
                return NotFound();
            }

            _context.ForumPosts.Remove(forumPost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ForumPostExists(int id)
        {
            return (_context.ForumPosts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
