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
        public async Task<ActionResult<List<ForumCategoryDto>>> GetForumCategories()
        {
            var forumCategories= await _context.ForumCategories.ToListAsync();
            List<ForumCategoryDto> forumCategoriesDto = new List<ForumCategoryDto>();
            
            foreach (var category in forumCategories)
            {
                forumCategoriesDto.Add(new ForumCategoryDto() { Id=category.Id, Name=category.Name, Description=category.Description });
            }
            return Ok(forumCategoriesDto);
        }

        // GET: api/ForumCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ForumCategoryDto>> GetForumCategory(int id)
        {
            if (_context.ForumCategories == null)
            {
                return NotFound();
            }
            var category = await _context.ForumCategories.FindAsync(id);
            //category.Threads= await _context.ForumThreads.Where(x => x.CategoryId == id).ToListAsync();

            if (category == null)
            {
                return NotFound();
            }

            return new ForumCategoryDto() { Id = category.Id, Name = category.Name, Description = category.Description };
        }
        // POST: api/ForumCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ForumCategoryDto>> PostForumCategory(ForumCategoryDto category)
        {
            if (_context.ForumCategories is null)
            {
                return Problem("Entity set 'AppDbContext.ForumCategories'  is null.");
            }
            ForumCategory forumCategory= new ForumCategory() { Name = category.Name, Description = category.Description, Threads= new List<ForumThread>() };
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
