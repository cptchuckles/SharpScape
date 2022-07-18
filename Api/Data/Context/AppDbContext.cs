using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Models;

namespace SharpScape.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<GameAvatar> GameAvatars { get; set; }
    
    public DbSet<ForumCategory> ForumCategories { get; set; }
    public DbSet<ForumThread> ForumThreads { get; set; }
    public DbSet<ForumPost> ForumPosts { get; set; }
    public DbSet<ThreadLike> ThreadLikes{ get; set; }
}