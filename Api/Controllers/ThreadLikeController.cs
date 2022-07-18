using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data;
using SharpScape.Api.Models;
using SharpScape.Shared.Dto;
namespace SharpScape.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThreadLikeController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ThreadLikeController(AppDbContext context)
        {
            _context = context;
        }
        // GET: get a list of users that liked the thread based on threadid
        [HttpGet]
        public async Task<ActionResult<List<ThreadLike>>> GetThreadLike()
        {
            var threadLikes = await _context.ThreadLikes.ToListAsync();
            // List<ForumCategoryDto> forumCategoriesDto = new List<ForumCategoryDto>();
            return Ok(threadLikes);
        }
        // GET: get a list of users based on threadid
        [HttpGet("{id}")]
        public async Task<ActionResult<List<ThreadLikeDto>>> GetUserLike(int id)
        {
            var threadLikes = await _context.ThreadLikes.Where(x => x.ThreadId == id).ToListAsync();
            List<ThreadLikeDto> threadLikeDtos = new List<ThreadLikeDto>();
            foreach (var item in threadLikes)
            {
                threadLikeDtos.Add(new ThreadLikeDto(){
                    Id=item.Id,
                    ThreadId=item.ThreadId,
                    UserId=item.UserId
                });
            }
            return Ok(threadLikeDtos);
        }
        // POST: add user to threadlike list based on both threadid and userid
        [HttpPost("{id}")]
        public async Task<ActionResult> UserLike(int id)
        {
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value);
            if (_context.ThreadLikes is null)
            {
                return Problem("Entity set 'AppDbContext.ForumCategories'  is null.");
            }
            var alreadyLiked = await _context.ThreadLikes.Where(x => x.ThreadId == id).Where(x=>x.UserId==userId).ToListAsync();
            if (alreadyLiked.Count > 0)
            {
                return BadRequest(alreadyLiked);
            }
            ThreadLike threadLike = new ThreadLike() {
                UserId=userId,
                ThreadId=id
            };
            _context.ThreadLikes.Add(threadLike);
            await _context.SaveChangesAsync();
            var threadLikes = await _context.ThreadLikes.Where(x => x.ThreadId == id).ToListAsync();
            List<ThreadLikeDto> threadLikeDtos = new List<ThreadLikeDto>();
            foreach (var item in threadLikes)
            {
                threadLikeDtos.Add(new ThreadLikeDto(){
                    Id=item.Id,
                    ThreadId=item.ThreadId,
                    UserId=item.UserId
                });
            }
            return Ok(threadLikeDtos);
        }
        // DELETE: remove user from threadlike list based on both threadid and userid
        [HttpPost("unliked/{id}")]
        public async Task<IActionResult> DeleteForumCategory(int id)
        {
            if (_context.ThreadLikes == null)
            {
                return NotFound();
            }
            var userId = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value);
            var threadLike = await _context.ThreadLikes.Where(x => x.ThreadId == id).Where(x=>x.UserId==userId).ToListAsync();
            if (threadLike == null)
            {
                return NotFound();
            }
            _context.ThreadLikes.Remove(threadLike[0]);
            await _context.SaveChangesAsync();
            var threadLikes = await _context.ThreadLikes.Where(x => x.ThreadId == id).ToListAsync();
            List<ThreadLikeDto> threadLikeDtos = new List<ThreadLikeDto>();
            foreach (var item in threadLikes)
            {
                threadLikeDtos.Add(new ThreadLikeDto(){
                    Id=item.Id,
                    ThreadId=item.ThreadId,
                    UserId=item.UserId
                });
            }
            return Ok(threadLikeDtos);
        }
    }
}
