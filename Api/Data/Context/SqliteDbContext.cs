using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Models;

namespace SharpScape.Api.Data;

public class SqliteDbContext : AppDbContext
{
    public SqliteDbContext(DbContextOptions options) : base(options)
    {
    }
}