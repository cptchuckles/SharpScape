using Microsoft.EntityFrameworkCore;

namespace SharpScape.Api.Data;

public class SqliteDbContext : AppDbContext
{
    public SqliteDbContext(DbContextOptions options) : base(options)
    {
    }
}