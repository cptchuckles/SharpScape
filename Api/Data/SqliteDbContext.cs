using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Models;

namespace SharpScape.Api.Data;

public class SqliteDbContext : DbContext
{
    public SqliteDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}