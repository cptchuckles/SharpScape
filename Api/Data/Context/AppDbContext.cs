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
                new User() { Id = 1, Email = "ss1@ss.ss", Created=DateTime.Now, Username="ss1", PasswordHash= new byte[32], PasswordSalt= new byte[32] },
                new User() { Id = 2, Email = "ss2@ss.ss", Created = DateTime.Now, Username = "ss2", PasswordHash = new byte[32], PasswordSalt = new byte[32] },
                new User() { Id = 3, Email = "ss3@ss.ss", Created = DateTime.Now, Username = "ss3", PasswordHash = new byte[32], PasswordSalt = new byte[32] }
                );
        });



        modelBuilder.Entity<ForumCategory>(x =>
        { 
            x.HasData(
                new ForumCategory(){ Id = 1, ForumCategoryName = "Category Name 1", ForumCategoryDescription = "Category Description 1", ForumCategoryAuthor = "Category Author 1 "},
                new ForumCategory(){ Id = 2, ForumCategoryName = "Category Name 2", ForumCategoryDescription = "Category Description 2", ForumCategoryAuthor = "Category Author 2" },
                new ForumCategory(){ Id = 3, ForumCategoryName = "Category Name 3", ForumCategoryDescription = "Category Description 3", ForumCategoryAuthor = "Category Author 3" }
                );
        });
    
        

        modelBuilder.Entity<ForumThread>(x =>
        {
          x.HasData(
               new ForumThread() { Id = 5, Title = "tr1", CategoryId = 2, Body = " body 1", Created = DateTime.Now, Replies = 0, Views = 0, Votes = 0, UserId = 2 },
                new ForumThread() { Id = 4, Title = "tr1", CategoryId = 2, Body = " body 1", Created = DateTime.Now, Replies = 0, Views = 0, Votes = 0, UserId = 1 },
                 new ForumThread() { Id = 3, Title = "tr1", CategoryId = 1, Body = " body 1", Created = DateTime.Now, Replies = 0, Views = 0, Votes = 0, UserId = 1 },
                 new ForumThread() { Id = 2, Title = "tr1", CategoryId = 3, Body = " body 1", Created = DateTime.Now, Replies = 0, Views = 0, Votes = 0, UserId = 3}
                  );
        });




        modelBuilder.Entity<ForumPost>(x =>
        {
           x.HasData(
                 new ForumPost() { Id =1, ForumPostBody="post1  Body", ForumPostTitle="post1 title", ForumAuthorId=1, ForumThreadId=2 },
                new ForumPost() { Id = 2, ForumPostBody = "post2  Body", ForumPostTitle = "post2 title", ForumAuthorId =1, ForumThreadId =3 },
                new ForumPost() { Id = 3, ForumPostBody = "post3  Body", ForumPostTitle = "post3 title", ForumAuthorId = 1, ForumThreadId =3 },
                new ForumPost() { Id = 4, ForumPostBody = "post4  Body", ForumPostTitle = "post4 title", ForumAuthorId = 2, ForumThreadId = 3 },
                new ForumPost() { Id = 5, ForumPostBody = "post5  Body", ForumPostTitle = "post5 title", ForumAuthorId = 2, ForumThreadId = 4 },
                new ForumPost() { Id = 6, ForumPostBody = "post6  Body", ForumPostTitle = "post6 title", ForumAuthorId = 3, ForumThreadId = 5 },
                new ForumPost() { Id = 7, ForumPostBody = "post7  Body", ForumPostTitle = "post7 title", ForumAuthorId = 3, ForumThreadId = 5 }
                 );
        });


    }
}