using Microsoft.EntityFrameworkCore.Migrations;
using SharpScape.Api.Models;

#nullable disable

namespace SharpScape.Api.Data.Migrations.Sqlite
{
    public partial class Seed_Users : Migration
    {
        List<User> seedUsers = new() {
            new User("Admin", "admin@sharpscape.net", "StrongPassword12345") { Id = 10 },
            new User("Pringleton", "pringle@example.com", "StrongPringle") { Id = 20 },
            new User("John Dotnet", "john@dot.net", "ilovedotnet123") { Id = 30 }
        };

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            foreach (var user in seedUsers)
            {
                migrationBuilder.InsertData("Users",
                    new[] { "Id", "Username", "Email", "PasswordHash", "PasswordSalt", "Created" },
                    new object[] { user.Id, user.Username, user.Email, user.PasswordHash, user.PasswordSalt, user.Created }
                );
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var rows = new string[seedUsers.Count, 2];
            int i=0;
            foreach (var user in seedUsers)
            {
                rows[i, 0] = user.Username;
                rows[i, 1] = user.Email;
                i++;
            }

            migrationBuilder.DeleteData("Users",
                new[] { "Username", "Email" },
                rows);
        }
    }
}
