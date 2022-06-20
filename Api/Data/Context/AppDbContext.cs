using Microsoft.EntityFrameworkCore;

using SharpScape.Api.Models;

namespace SharpScape.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<ForumThread> ForumThreads { get; set; }
    public DbSet<ForumCategory> ForumCategorys { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ForumCategory>(x =>
        {
            x.HasData(
                new ForumCategory(){ Id = Guid.NewGuid(), ForumCategoryName = "Category Name 1", ForumCategoryDescription = "Category Description 1", ForumCategoryAuthor = "Category Author 1" },
                new ForumCategory(){ Id = Guid.NewGuid(), ForumCategoryName = "Category Name 2", ForumCategoryDescription = "Category Description 2", ForumCategoryAuthor = "Category Author 2" },
                new ForumCategory(){ Id = Guid.NewGuid(), ForumCategoryName = "Category Name 3", ForumCategoryDescription = "Category Description 3", ForumCategoryAuthor = "Category Author 3" }
                );
        });

    }
}