using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data;
using SharpScape.Api.Models;

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

        // GET: api/ForumPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ForumPost>>> GetForumPosts()
        {
          if (_context.ForumPosts == null)
          {
              return NotFound();
          }
            return await _context.ForumPosts.ToListAsync();
        }

        // GET: api/ForumPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ForumPost>> GetForumPost(int id)
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

            return forumPost;
        }

        // PUT: api/ForumPosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForumPost(int id, ForumPost forumPost)
        {
            if (id != forumPost.Id)
            {
                return BadRequest();
            }

            _context.Entry(forumPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ForumPostExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // GET: api/Threads/5
        [HttpGet("Thread{id}")]
        public async Task<ActionResult<List<ForumPost>>> GetForumThreadbyCategory(int id)
        {
            if (_context.ForumPosts == null)
            {
                return NotFound();
            }
            var forumPosts = await _context.ForumPosts.Where(x => x.ThreadId == id).ToListAsync();

            if (forumPosts == null)
            {
                return NotFound();
            }

            return forumPosts;
        }



        // POST: api/ForumPosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ForumPost>> PostForumPost(ForumPost forumPost)
        {
          if (_context.ForumPosts == null)
          {
              return Problem("Entity set 'AppDbContext.ForumPosts'  is null.");
          }
            _context.ForumPosts.Add(forumPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForumPost", new { id = forumPost.Id }, forumPost);
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
