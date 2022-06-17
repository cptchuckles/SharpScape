using SharpScape.Api.Models;
using SharpScape.Api.Data;
using SharpScape.Shared.Dto;
using SharpScape.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Thread = SharpScape.Api.Models.Thread;
namespace SharpScape.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ThreadController : ControllerBase
{
    private readonly AppDbContext _context;

    public ThreadController(AppDbContext context)
    {
        _context = context;
    }
    // Api to return all threads since we dont have category table it will return threads of all categories
    [HttpGet,Route("threads")]
    public async Task<ActionResult<IEnumerable<Thread>>> GetThreads()
    {
        return await _context.Threads.ToListAsync();
    }
    [HttpGet("{id}")]
    // Api to return info about a thread (title, author, body.. no posts since we dont have post table)
    // @para ThreadId
    public ActionResult<ThreadInfoDto> GetThread(Guid id)
    {
        var thread = _context.Threads.FirstOrDefault(thread => thread.Id == id);
        if (thread is null){
            return BadRequest("Thread not found!!");
        }
        var threadInfo = new ThreadInfoDto() {
            Id = thread.Id,
            Title = thread.Title,
            Votes = thread.Votes,
            Replies = thread.Replies,
            Views = thread.Views 
        };
        return Ok(threadInfo);
    }
}