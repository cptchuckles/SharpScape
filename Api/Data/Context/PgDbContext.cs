using Microsoft.EntityFrameworkCore;

namespace SharpScape.Api.Data;

public class PgDbContext : AppDbContext
{
    public PgDbContext(DbContextOptions options) : base(options)
    {
    }
}