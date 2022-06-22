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
    public class ForumThreadsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ForumThreadsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ForumThreads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ForumThread>>> GetForumThreads()
        {
          if (_context.ForumThreads == null)
          {
              return NotFound();
          }
            return await _context.ForumThreads.ToListAsync();
        }


        // GET: api/ForumThreads/5
        [HttpGet("category{id}")]
        public async Task<ActionResult<List<ForumThread>>> GetForumThreadbyCategory(int id)
        {
            if (_context.ForumThreads == null)
            {
                return NotFound();
            }
            var forumThread = await _context.ForumThreads.Where(x => x.CategoryId == id).ToListAsync();

            if (forumThread == null)
            {
                return NotFound();
            }

            return forumThread;
        }

        // GET: api/ForumThreads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ForumThread>> GetForumThread(int id)
        {
          if (_context.ForumThreads == null)
          {
              return NotFound();
          }
            var forumThread = await _context.ForumThreads.FindAsync(id);

            if (forumThread == null)
            {
                return NotFound();
            }

            return forumThread;
        }

        // PUT: api/ForumThreads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForumThread(int id, ForumThread forumThread)
        {
            if (id != forumThread.Id)
            {
                return BadRequest();
            }

            _context.Entry(forumThread).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (ForumThreadExists(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            return NoContent();
        }

        // POST: api/ForumThreads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ForumThread>> PostForumThread(ForumThread forumThread)
        {
          if (_context.ForumThreads == null)
          {
              return Problem("Entity set 'AppDbContext.ForumThreads'  is null.");
          }
            _context.ForumThreads.Add(forumThread);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForumThread", new { id = forumThread.Id }, forumThread);
        }

        // DELETE: api/ForumThreads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForumThread(int id)
        {
            if (_context.ForumThreads == null)
            {
                return NotFound();
            }
            var forumThread = await _context.ForumThreads.FindAsync(id);
            if (forumThread == null)
            {
                return NotFound();
            }

            _context.ForumThreads.Remove(forumThread);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ForumThreadExists(int id)
        {
            return (_context.ForumThreads?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
