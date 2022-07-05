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
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 1, new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(4216), "admin@sharpscape.net", new byte[] { 156, 172, 177, 44, 60, 11, 22, 184, 154, 251, 9, 216, 139, 106, 108, 16, 139, 114, 142, 224, 89, 197, 54, 205, 184, 148, 67, 143, 30, 120, 175, 147, 130, 222, 199, 89, 109, 108, 72, 21, 7, 58, 44, 233, 111, 129, 222, 25, 117, 240, 68, 120, 40, 178, 233, 74, 58, 4, 55, 255, 75, 194, 225, 161 }, new byte[] { 245, 108, 46, 58, 222, 8, 237, 223, 104, 160, 192, 73, 227, 128, 199, 83, 246, 81, 111, 158, 130, 9, 1, 241, 27, 231, 232, 63, 153, 10, 147, 187, 228, 50, 14, 36, 55, 2, 46, 112, 187, 47, 6, 100, 19, 156, 77, 3, 0, 180, 203, 79, 114, 62, 178, 203, 30, 139, 214, 123, 230, 109, 2, 249, 188, 61, 19, 245, 56, 209, 166, 140, 151, 216, 186, 207, 28, 161, 119, 115, 224, 190, 204, 7, 217, 48, 44, 205, 162, 146, 189, 90, 195, 94, 24, 188, 131, 11, 173, 103, 95, 127, 194, 150, 186, 15, 151, 44, 81, 20, 174, 100, 178, 179, 176, 29, 84, 23, 126, 103, 198, 24, 168, 198, 176, 155, 0, 173 }, "User", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 2, new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(4614), "pringle@example.com", new byte[] { 114, 29, 106, 210, 63, 167, 105, 70, 28, 12, 222, 88, 137, 142, 228, 101, 37, 170, 23, 202, 134, 88, 138, 234, 82, 0, 203, 238, 136, 136, 175, 227, 192, 30, 222, 243, 38, 59, 77, 152, 199, 52, 120, 23, 2, 159, 108, 216, 20, 93, 204, 97, 70, 44, 140, 252, 239, 28, 138, 14, 87, 175, 216, 93 }, new byte[] { 191, 124, 45, 251, 52, 24, 175, 110, 129, 205, 111, 123, 180, 101, 73, 210, 46, 168, 160, 70, 7, 108, 218, 148, 83, 105, 183, 137, 93, 92, 55, 157, 212, 102, 216, 237, 164, 93, 210, 224, 196, 81, 190, 163, 220, 231, 49, 226, 2, 199, 149, 66, 55, 110, 91, 119, 205, 39, 66, 233, 153, 227, 132, 101, 245, 64, 48, 0, 164, 251, 236, 80, 244, 245, 107, 146, 207, 217, 97, 49, 7, 57, 134, 131, 78, 30, 234, 235, 141, 165, 236, 108, 66, 144, 86, 40, 249, 250, 148, 79, 227, 95, 111, 125, 158, 135, 37, 108, 122, 36, 152, 187, 206, 83, 217, 58, 45, 109, 54, 47, 193, 151, 36, 36, 137, 61, 93, 180 }, "User", "Pringleton" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 3, new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(4663), "john@dot.net", new byte[] { 39, 251, 34, 40, 198, 234, 123, 10, 253, 203, 230, 246, 17, 228, 180, 54, 194, 188, 160, 161, 88, 58, 40, 66, 105, 56, 107, 251, 61, 8, 91, 205, 92, 226, 13, 238, 240, 91, 155, 214, 168, 132, 153, 213, 61, 119, 175, 248, 154, 130, 46, 233, 137, 153, 239, 186, 75, 61, 232, 242, 180, 35, 122, 186 }, new byte[] { 175, 101, 183, 210, 31, 162, 230, 104, 109, 89, 187, 47, 203, 185, 206, 26, 240, 102, 139, 75, 215, 237, 171, 223, 144, 94, 211, 83, 126, 174, 97, 118, 45, 114, 151, 34, 255, 198, 92, 126, 64, 46, 9, 153, 99, 13, 43, 82, 174, 172, 6, 17, 171, 102, 187, 247, 110, 91, 186, 141, 243, 50, 40, 29, 16, 191, 131, 225, 128, 158, 57, 134, 142, 151, 192, 151, 237, 72, 237, 73, 46, 110, 3, 183, 9, 135, 89, 218, 38, 194, 89, 153, 196, 231, 62, 226, 254, 251, 138, 185, 2, 139, 204, 227, 120, 252, 127, 47, 12, 115, 38, 30, 185, 82, 174, 29, 160, 86, 43, 207, 173, 193, 103, 209, 255, 68, 77, 212 }, "User", "John Dotnet" });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 1, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 1, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5012), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 2, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 1, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5079), 0, "qui est esse", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 3, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 1, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5100), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 4, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 1, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5110), 0, "eum et est occaecati", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 5, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 1, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5121), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 6, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 1, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5131), 0, "dolorem eum magni eos aperiam quia", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 7, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 1, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5141), 0, "magnam facilis autem", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 8, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 1, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5152), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 9, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 2, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5229), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 10, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 2, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5238), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 11, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 2, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5248), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 12, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 2, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5259), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 13, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 2, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5268), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 14, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 2, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5277), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 15, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 2, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5286), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 16, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 2, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5295), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 17, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5304), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 18, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5314), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 19, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5323), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 20, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5349), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 21, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5362), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 22, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5373), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 23, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5383), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 24, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5393), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 25, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5404), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 26, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5413), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 27, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5422), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 28, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5430), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 29, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5439), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 30, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5447), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 31, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5455), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 32, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5464), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 33, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 5, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5472), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 34, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 5, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5481), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 35, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 5, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5489), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 36, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 5, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5498), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 37, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 5, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5506), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 38, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 5, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5515), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 39, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 5, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5523), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 40, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 5, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5531), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 41, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 6, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5540), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 42, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 6, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5548), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 43, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 6, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5556), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 44, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 6, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5565), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 45, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 6, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5573), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 46, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 6, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5582), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 47, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 6, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5590), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 48, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 6, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5598), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 49, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 7, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5607), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 50, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 7, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5615), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 51, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 7, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5624), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 52, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 7, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5632), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 53, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 7, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5641), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 54, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 7, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5649), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 55, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 7, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5658), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 56, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 7, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5666), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 57, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 8, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5674), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 58, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 8, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5683), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 59, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 8, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5691), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 60, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 8, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5700), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 61, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 8, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5708), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 62, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 8, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5717), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 63, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 8, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5725), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 64, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 8, new DateTime(2022, 7, 1, 19, 25, 42, 776, DateTimeKind.Local).AddTicks(5734), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 1, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5806), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 2, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5818), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 3, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5824), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 4, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5829), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 5, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5834), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 6, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5841), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 7, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5847), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 8, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5852), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 9, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5857), 9 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 10, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5864), 10 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 11, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5869), 11 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 12, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5875), 12 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 13, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5880), 13 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 14, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5885), 14 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 15, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5891), 15 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 16, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5896), 16 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 17, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5901), 17 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 18, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5908), 18 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 19, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5913), 19 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 20, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5919), 20 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 21, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5924), 21 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 22, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5929), 22 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 23, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5935), 23 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 24, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5940), 24 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 25, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5945), 25 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 26, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5950), 26 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 27, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5956), 27 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 28, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(5961), 28 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 29, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6004), 29 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 30, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6010), 30 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 31, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6015), 31 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 32, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6021), 32 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 33, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6026), 33 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 34, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6033), 34 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 35, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6039), 35 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 36, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6044), 36 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 37, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6049), 37 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 38, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6054), 38 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 39, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6060), 39 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 40, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6065), 40 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 41, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6070), 41 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 42, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6076), 42 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 43, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6081), 43 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 44, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6086), 44 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 45, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6092), 45 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 46, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6097), 46 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 47, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6103), 47 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 48, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6108), 48 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 49, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6113), 49 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 50, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6119), 50 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 51, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6124), 51 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 52, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6129), 52 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 53, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6135), 53 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 54, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6140), 54 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 55, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6145), 55 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 56, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6151), 56 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 57, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6156), 57 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 58, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6161), 58 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 59, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6167), 59 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 60, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6172), 60 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 61, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6177), 61 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 62, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6183), 62 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 63, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6188), 63 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 64, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 7, 2, 2, 25, 42, 776, DateTimeKind.Utc).AddTicks(6193), 64 });

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
