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
    public class ForumCategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ForumCategoriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ForumCategories
        [HttpGet]
        public async Task<List<ForumCategory>> GetForumCategories()
        {
            var forumCategories= await _context.ForumCategories.ToListAsync();
            forumCategories.ForEach(async category => category.Threads = await _context.ForumThreads.Where(x => x.CategoryId == category.Id).ToListAsync());

            return forumCategories;
        }

        // GET: api/ForumCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ForumCategory>> GetForumCategory(int id)
        {
          if (_context.ForumCategories == null)
          {
              return NotFound();
          }
            var forumCategory = await _context.ForumCategories.FindAsync(id);
            forumCategory.Threads= await _context.ForumThreads.Where(x => x.CategoryId == id).ToListAsync();

            if (forumCategory == null)
            {
                return NotFound();
            }

            return forumCategory;
        }

        // PUT: api/ForumCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForumCategory(int id, ForumCategory forumCategory)
        {
            if (id != forumCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(forumCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ForumCategoryExists(id))
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

        // POST: api/ForumCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ForumCategory>> PostForumCategory(ForumCategory forumCategory)
        {
            if (_context.ForumCategories is null)
            {
                return Problem("Entity set 'AppDbContext.ForumCategories'  is null.");
            }
            _context.ForumCategories.Add(forumCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForumCategory", new { id = forumCategory.Id }, forumCategory);
        }

        // DELETE: api/ForumCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForumCategory(int id)
        {
            if (_context.ForumCategories == null)
            {
                return NotFound();
            }
            var forumCategory = await _context.ForumCategories.FindAsync(id);
            if (forumCategory == null)
            {
                return NotFound();
            }

            _context.ForumCategories.Remove(forumCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ForumCategoryExists(int id)
        {
            return (_context.ForumCategories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
