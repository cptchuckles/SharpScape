using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data.Models;
using SharpScape.Api.Models;

namespace SharpScape.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    
    public DbSet<ForumCategory> ForumCategories { get; set; }
    public DbSet<ForumThread> ForumThreads { get; set; }
    public DbSet<ForumPost> ForumPosts { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(x =>
        {
            x.HasData(
                new User() { Id = Guid.NewGuid(), Email = "ss1@ss.ss", Created=DateTime.Now, Username="ss1", PasswordHash= new byte[32], PasswordSalt= new byte[32] },
                new User() { Id = Guid.NewGuid(), Email = "ss2@ss.ss", Created = DateTime.Now, Username = "ss2", PasswordHash = new byte[32], PasswordSalt = new byte[32] },
                new User() { Id = Guid.NewGuid(), Email = "ss3@ss.ss", Created = DateTime.Now, Username = "ss3", PasswordHash = new byte[32], PasswordSalt = new byte[32] }
                );
        });



        modelBuilder.Entity<ForumCategory>(x =>
        { 
            x.HasData(
                new ForumCategory(){ Id = Guid.NewGuid(), ForumCategoryName = "Category Name 1", ForumCategoryDescription = "Category Description 1", ForumCategoryAuthor = "Category Author 1 "},
                new ForumCategory(){ Id = Guid.NewGuid(), ForumCategoryName = "Category Name 2", ForumCategoryDescription = "Category Description 2", ForumCategoryAuthor = "Category Author 2" },
                new ForumCategory(){ Id = Guid.NewGuid(), ForumCategoryName = "Category Name 3", ForumCategoryDescription = "Category Description 3", ForumCategoryAuthor = "Category Author 3" }
                );
        });
    
        

        modelBuilder.Entity<ForumThread>(x =>
        {
          x.HasData(
               new ForumThread() { Id = Guid.NewGuid(), Title = "tr1", CategoryId = Guid.Parse("61464988-a9df-46f9-a348-1d316b311a15"), Body = " body 1", Created = DateTime.Now, Replies = 0, Views = 0, Votes = 0, UserId = Guid.Parse("a7c720f9-48bd-4d6c-b234-e9cdfadd16b3") }
                  );
        });




        //modelBuilder.Entity<ForumPost>(x =>
        //{
        //    x.HasData(
        //         new ForumPost() { Id = Guid.NewGuid(), ForumPostBody="post1  Body", ForumPostTitle="post1 title", ForumAuthorId=Guid.Parse("a7c720f9-48bd-4d6c-b234-e9cdfadd16b3"), ForumThreadId=Guid.Empty },
        //         );
        //});


    }
}