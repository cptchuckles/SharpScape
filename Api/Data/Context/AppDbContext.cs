using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Models;

namespace SharpScape.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<SharpScape.Api.Models.Thread> Threads { get; set; }
}