using SharpScape.Api.Models;
using SharpScape.Api.Data;
using SharpScape.Shared.Dto;
using SharpScape.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    public async Task<ActionResult<IEnumerable<ThreadModel>>> GetThreads()
    {
        return await _context.ThreadModels.ToListAsync();
    }
    [HttpGet,Route("threads")]
    // Api to return info about a thread (title, author, body.. no posts since we dont have post table)
    // @para ThreadId
    public ActionResult<ThreadModel> GetThreadInfo([FromBody] ThreadDto request)
    {
        var threadInfo = _context.ThreadModels.FirstOrDefault(thread => thread.Id == request.Id);
        if (threadInfo is null){
            return BadRequest("Thread not found!!");
        }
        return Ok(threadInfo);
    }
}