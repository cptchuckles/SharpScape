using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpScape.Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForumCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProfilePicDataUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForumThreads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    Votes = table.Column<int>(type: "INTEGER", nullable: false),
                    Replies = table.Column<int>(type: "INTEGER", nullable: false),
                    Views = table.Column<int>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumThreads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumThreads_ForumCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ForumCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumThreads_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForumPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ThreadId = table.Column<int>(type: "INTEGER", nullable: false),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForumPosts_ForumThreads_ThreadId",
                        column: x => x.ThreadId,
                        principalTable: "ForumThreads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumPosts_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Talk about sports, entertainment, music, movies, your favorite color, talk about enything.", "General Discussion" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "New to the community? Please stop by, say hi and tell us a bit about yourself.", "Introductions" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "This forum features announcements from the community staff. If there is a new post in this forum, please check it out.", "Announcements" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, "This forum is for private, staff member only discussions, usually pertaining to the community itself.", "Staff Discussion" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 5, "Various versions have evolved over the years, sometimes by accident, sometimes on purpose passage of Lorem Ipsum (injected humour and the like).", "Lorem Ipsum is simply dummy text" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 6, "If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the.", "There are many variations of passages" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 7, "Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet.", "The standard chunk of Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 8, "Internet tend to repeat predefined chunks as necessary, making this the.", "Lorem Ipsum, you need to be sure there" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "ProfilePicDataUrl", "Role", "Username" },
                values: new object[] { 1, new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(5736), "admin@sharpscape.net", new byte[] { 184, 57, 44, 206, 147, 167, 119, 175, 221, 152, 202, 95, 197, 81, 37, 125, 198, 172, 20, 252, 27, 111, 71, 55, 41, 251, 135, 145, 158, 124, 53, 115, 160, 67, 124, 198, 205, 170, 247, 119, 144, 39, 24, 254, 110, 246, 131, 196, 109, 250, 253, 255, 175, 71, 192, 161, 238, 4, 45, 193, 45, 153, 86, 154 }, new byte[] { 69, 177, 83, 207, 125, 194, 171, 211, 51, 136, 134, 89, 211, 45, 152, 52, 69, 139, 248, 17, 116, 246, 202, 215, 89, 5, 173, 21, 246, 155, 215, 183, 81, 30, 182, 223, 116, 119, 49, 254, 229, 55, 189, 201, 234, 63, 192, 142, 58, 185, 49, 98, 183, 157, 0, 48, 205, 73, 86, 102, 209, 172, 23, 27, 111, 250, 252, 68, 21, 173, 176, 152, 249, 28, 100, 76, 25, 29, 162, 16, 132, 20, 225, 193, 187, 93, 215, 13, 252, 215, 78, 25, 183, 40, 193, 108, 243, 165, 104, 76, 71, 54, 214, 255, 118, 241, 97, 47, 146, 136, 255, 0, 128, 220, 42, 84, 90, 93, 122, 254, 6, 96, 203, 193, 184, 154, 104, 19 }, "", "User", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "ProfilePicDataUrl", "Role", "Username" },
                values: new object[] { 2, new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(6138), "pringle@example.com", new byte[] { 124, 6, 125, 101, 20, 50, 35, 113, 209, 77, 218, 62, 106, 133, 12, 93, 194, 218, 54, 210, 9, 179, 195, 255, 124, 99, 151, 239, 150, 253, 130, 56, 121, 185, 158, 216, 122, 118, 55, 5, 100, 62, 137, 207, 91, 165, 179, 16, 57, 132, 102, 14, 71, 128, 246, 208, 43, 190, 53, 214, 188, 10, 80, 189 }, new byte[] { 81, 130, 218, 116, 76, 22, 249, 233, 34, 210, 64, 85, 30, 209, 78, 231, 204, 224, 215, 52, 149, 138, 13, 178, 246, 122, 154, 182, 2, 69, 157, 16, 234, 105, 211, 187, 103, 147, 198, 43, 209, 137, 214, 160, 0, 128, 104, 120, 128, 81, 103, 155, 207, 93, 179, 238, 181, 2, 194, 59, 129, 49, 115, 223, 10, 111, 115, 89, 37, 244, 14, 236, 107, 84, 38, 145, 29, 89, 15, 196, 59, 221, 171, 99, 50, 27, 42, 208, 27, 11, 138, 50, 142, 236, 216, 157, 21, 5, 158, 74, 209, 247, 135, 150, 231, 131, 53, 165, 50, 18, 216, 205, 188, 41, 8, 210, 7, 253, 111, 39, 195, 240, 31, 159, 123, 214, 145, 114 }, "", "User", "Pringleton" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "ProfilePicDataUrl", "Role", "Username" },
                values: new object[] { 3, new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(6183), "john@dot.net", new byte[] { 106, 11, 211, 68, 16, 200, 142, 73, 14, 95, 166, 137, 130, 199, 63, 241, 243, 123, 210, 87, 237, 187, 216, 249, 133, 251, 54, 156, 49, 103, 144, 233, 136, 35, 138, 120, 76, 184, 119, 26, 140, 235, 144, 149, 131, 222, 152, 149, 236, 192, 107, 120, 244, 0, 241, 234, 182, 194, 202, 183, 199, 209, 181, 252 }, new byte[] { 23, 118, 220, 89, 90, 139, 63, 69, 182, 134, 138, 177, 162, 88, 127, 119, 137, 37, 17, 242, 45, 245, 92, 124, 155, 67, 150, 174, 89, 14, 164, 70, 181, 106, 124, 56, 108, 200, 40, 56, 227, 169, 140, 13, 210, 243, 73, 90, 26, 193, 144, 109, 3, 119, 40, 102, 51, 85, 72, 231, 70, 15, 231, 170, 24, 132, 66, 82, 113, 203, 169, 183, 117, 233, 190, 43, 245, 141, 18, 73, 247, 92, 195, 253, 194, 216, 156, 98, 118, 246, 141, 215, 28, 61, 198, 101, 180, 68, 220, 169, 198, 80, 222, 93, 172, 167, 33, 112, 54, 93, 151, 225, 58, 56, 240, 65, 223, 116, 225, 237, 115, 223, 204, 99, 146, 164, 160, 132 }, "", "User", "John Dotnet" });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 1, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 1, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6505), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 2, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 1, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6513), 0, "qui est esse", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 3, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 1, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6520), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 4, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 1, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6526), 0, "eum et est occaecati", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 5, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 1, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6533), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 6, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 1, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6540), 0, "dolorem eum magni eos aperiam quia", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 7, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 1, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6547), 0, "magnam facilis autem", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 8, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 1, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6553), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 9, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 2, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6633), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 10, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 2, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6641), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 11, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 2, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6647), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 12, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 2, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6654), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 13, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 2, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6661), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 14, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 2, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6668), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 15, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 2, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6674), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 16, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 2, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6681), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 17, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6688), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 18, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6695), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 19, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6702), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 20, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6708), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 21, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6715), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 22, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6722), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 23, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6729), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 24, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6735), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 25, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6742), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 26, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6749), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 27, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6755), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 28, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6762), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 29, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6769), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 30, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6775), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 31, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6782), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 32, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6789), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 33, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 5, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6795), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 34, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 5, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6802), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 35, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 5, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6808), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 36, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 5, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6815), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 37, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 5, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6822), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 38, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 5, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6828), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 39, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 5, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6835), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 40, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 5, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6842), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 41, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 6, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6848), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 42, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 6, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6855), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 43, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 6, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6861), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 44, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 6, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6868), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 45, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 6, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6875), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 46, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 6, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6881), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 47, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 6, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6888), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 48, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 6, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6895), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 49, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 7, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6902), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 50, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 7, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6908), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 51, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 7, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6915), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 52, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 7, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6922), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 53, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 7, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6928), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 54, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 7, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6935), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 55, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 7, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6942), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 56, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 7, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6948), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 57, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 8, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6955), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 58, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 8, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6962), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 59, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 8, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6968), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 60, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 8, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6975), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 61, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 8, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6982), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 62, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 8, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6989), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 63, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 8, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(6996), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 64, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 8, new DateTime(2022, 7, 6, 17, 5, 13, 253, DateTimeKind.Local).AddTicks(7002), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 1, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7052), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 2, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7061), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 3, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7066), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 4, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7070), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 5, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7075), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 6, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7080), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 7, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7085), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 8, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7089), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 9, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7093), 9 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 10, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7099), 10 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 11, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7103), 11 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 12, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7108), 12 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 13, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7112), 13 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 14, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7116), 14 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 15, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7120), 15 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 16, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7124), 16 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 17, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7129), 17 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 18, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7134), 18 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 19, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7138), 19 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 20, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7143), 20 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 21, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7147), 21 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 22, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7151), 22 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 23, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7155), 23 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 24, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7160), 24 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 25, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7164), 25 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 26, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7168), 26 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 27, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7172), 27 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 28, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7212), 28 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 29, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7218), 29 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 30, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7222), 30 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 31, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7226), 31 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 32, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7230), 32 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 33, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7234), 33 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 34, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7240), 34 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 35, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7244), 35 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 36, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7249), 36 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 37, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7253), 37 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 38, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7257), 38 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 39, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7261), 39 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 40, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7265), 40 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 41, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7269), 41 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 42, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7274), 42 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 43, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7278), 43 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 44, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7282), 44 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 45, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7286), 45 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 46, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7290), 46 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 47, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7294), 47 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 48, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7298), 48 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 49, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7303), 49 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 50, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7307), 50 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 51, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7311), 51 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 52, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7315), 52 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 53, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7319), 53 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 54, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7324), 54 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 55, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7328), 55 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 56, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7332), 56 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 57, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7336), 57 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 58, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7340), 58 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 59, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7344), 59 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 60, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7348), 60 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 61, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7353), 61 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 62, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7357), 62 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 63, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7361), 63 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 64, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 7, 0, 5, 13, 253, DateTimeKind.Utc).AddTicks(7365), 64 });

            migrationBuilder.CreateIndex(
                name: "IX_ForumPosts_AuthorId",
                table: "ForumPosts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPosts_ThreadId",
                table: "ForumPosts",
                column: "ThreadId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumThreads_CategoryId",
                table: "ForumThreads",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumThreads_UserId",
                table: "ForumThreads",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumPosts");

            migrationBuilder.DropTable(
                name: "ForumThreads");

            migrationBuilder.DropTable(
                name: "ForumCategories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
