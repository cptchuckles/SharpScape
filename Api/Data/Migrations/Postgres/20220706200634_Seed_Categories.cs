using Microsoft.EntityFrameworkCore.Migrations;
using SharpScape.Api.Models;

#nullable disable

namespace SharpScape.Api.Data.Migrations.Postgres
{
    public partial class Seed_Categories : Migration
    {
        private List<ForumCategory> forumCategories = new() {
            new ForumCategory(){ 
                Id = 1, 
                Name = "General Discussion", 
                Description = "Talk about sports, entertainment, music, movies, your favorite color, talk about enything."
            },
            new ForumCategory(){ 
                Id = 2, 
                Name = "Introductions", 
                Description = "New to the community? Please stop by, say hi and tell us a bit about yourself."
            },
            new ForumCategory(){ 
                Id = 3, 
                Name = "Announcements", 
                Description = "This forum features announcements from the community staff. If there is a new post in this forum, please check it out."
            },
            new ForumCategory(){ 
                Id = 4, 
                Name = "Staff Discussion", 
                Description = "This forum is for private, staff member only discussions, usually pertaining to the community itself."
            },
            new ForumCategory(){ 
                Id = 5, 
                Name = "Lorem Ipsum is simply dummy text", 
                Description = "Various versions have evolved over the years, sometimes by accident, sometimes on purpose passage of Lorem Ipsum (injected humour and the like)."
            },
            new ForumCategory(){ 
                Id = 6, 
                Name = "There are many variations of passages", 
                Description = "If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the."
            },
            new ForumCategory(){ 
                Id = 7, 
                Name = "The standard chunk of Lorem Ipsum", 
                Description = "Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet."
            },
            new ForumCategory(){ 
                Id = 8, 
                Name = "Lorem Ipsum, you need to be sure there", 
                Description = "Internet tend to repeat predefined chunks as necessary, making this the."
            }
        };
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            foreach (var forumCategory in forumCategories)
            {
                migrationBuilder.InsertData("ForumCategories",
                    new[] { "Id", "Name", "Description" },
                    new object[] { forumCategory.Id, forumCategory.Name, forumCategory.Description });
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            foreach (var forumCategory in forumCategories)
            {
                migrationBuilder.DeleteData("ForumCategories", "Id", forumCategory.Id);
            }
        }
    }
}
