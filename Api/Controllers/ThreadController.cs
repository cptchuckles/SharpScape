using SharpScape.Api.Models;
using SharpScape.Api.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography;


namespace SharpScape.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class ThreadController : ControllerBase
{
    private readonly SqliteDbContext _context;
    public ThreadController(SqliteDbContext context)
    {
        _context= context?? throw new ArgumentNullException(nameof(context));
    }
    [HttpGet,Route("threads")]
}
