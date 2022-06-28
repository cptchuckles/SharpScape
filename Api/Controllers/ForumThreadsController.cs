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
        public async Task<ActionResult<List<ForumThreadDto>>> GetForumThreads()
        {
            var ft = await _context.ForumThreads.ToListAsync();
            List<ForumThreadDto> forumThreadDto = new List<ForumThreadDto>();
            foreach (var f in ft)
            {
                forumThreadDto.Add(new ForumThreadDto()
                {
                    Id = f.Id,
                    AuthorId = f.UserId,
                    CategoryId = f.CategoryId,
                    Replies = f.Replies,
                    Title = f.Title,
                    Views = f.Views,
                    Votes = f.Votes
                });
            }



            return forumThreadDto;
        }

      

        // GET: api/ForumThreads/5
        [HttpGet("category{id}")]
        public async Task<ActionResult<List<ForumThreadDto>>> GetForumThreadbyCategory(int id)
        {
            if (_context.ForumThreads == null)
            {
                return NotFound();
            }
            var ft = await _context.ForumThreads.Where(x => x.CategoryId == id).ToListAsync();

            List<ForumThreadDto> forumThreadDto = new List<ForumThreadDto>();
            foreach (var f in ft)
            {
                forumThreadDto.Add(new ForumThreadDto()
                {
                    Id = f.Id,
                    AuthorId = f.UserId,
                    CategoryId = f.CategoryId,
                    Replies = f.Replies,
                    Title = f.Title,
                    Views = f.Views,
                    Votes = f.Votes
                });
            }



            return forumThreadDto;
        }


        // GET: api/ForumThreads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ForumThreadDto>> GetForumThread(int id)
        {
            if (_context.ForumCategories == null)
            {
                return NotFound();
            }

            var f = await _context.ForumThreads.FindAsync(id);

            if (f == null)
            {
                return NotFound();
            }

            return new ForumThreadDto()
            {
                Id = f.Id,
                AuthorId = f.UserId,
                CategoryId = f.CategoryId,
                Replies = f.Replies,
                Title = f.Title,
                Views = f.Views,
                Votes = f.Votes
            };
        }

       

        // POST: api/ForumThreads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ForumThreadDto>> PostForumThread(ForumThreadDto forumThreadDto)
        {
            ForumThread forumThread = new ForumThread() { Author = _context.Users.Find(forumThreadDto.AuthorId), UserId = forumThreadDto.AuthorId, ForumCategory = _context.ForumCategories.Find(forumThreadDto.CategoryId), Body = "", CategoryId = forumThreadDto.CategoryId, Created = DateTime.Now, Title = forumThreadDto.Title };
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
