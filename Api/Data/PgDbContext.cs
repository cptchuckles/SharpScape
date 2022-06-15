using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Models;

namespace SharpScape.Api.Data;

public class PgDbContext : DbContext
{
    public PgDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}