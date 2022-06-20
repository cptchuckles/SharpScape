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
    public class ForumCategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ForumCategoriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ForumCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ForumCategory>>> GetForumCategorys()
        {


           
            
            
            
            if (_context.ForumCategorys == null)
          {
              return NotFound();
          }
            return await _context.ForumCategorys.ToListAsync();
        }

        // GET: api/ForumCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ForumCategory>> GetForumCategory(Guid id)
        {
          if (_context.ForumCategorys == null)
          {
              return NotFound();
          }
            var forumCategory = await _context.ForumCategorys.FindAsync(id);

            if (forumCategory == null)
            {
                return NotFound();
            }

            return forumCategory;
        }

        // PUT: api/ForumCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForumCategory(Guid id, ForumCategory forumCategory)
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
          if (_context.ForumCategorys == null)
          {
              return Problem("Entity set 'AppDbContext.ForumCategorys'  is null.");
          }
            _context.ForumCategorys.Add(forumCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForumCategory", new { id = forumCategory.Id }, forumCategory);
        }

        // DELETE: api/ForumCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForumCategory(Guid id)
        {
            if (_context.ForumCategorys == null)
            {
                return NotFound();
            }
            var forumCategory = await _context.ForumCategorys.FindAsync(id);
            if (forumCategory == null)
            {
                return NotFound();
            }

            _context.ForumCategorys.Remove(forumCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ForumCategoryExists(Guid id)
        {
            return (_context.ForumCategorys?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
