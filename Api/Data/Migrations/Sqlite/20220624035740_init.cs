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
                    Title = table.Column<string>(type: "TEXT", nullable: false),
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
                values: new object[] { 1, new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(2422), "admin@sharpscape.net", new byte[] { 54, 145, 59, 40, 237, 177, 17, 41, 177, 248, 144, 74, 6, 250, 168, 105, 254, 183, 95, 85, 208, 140, 75, 2, 28, 192, 223, 244, 156, 249, 242, 201, 78, 143, 121, 31, 101, 79, 47, 0, 162, 185, 113, 110, 235, 40, 17, 245, 96, 227, 52, 48, 117, 159, 8, 43, 27, 189, 25, 44, 0, 78, 127, 95 }, new byte[] { 121, 237, 87, 119, 185, 38, 42, 167, 104, 152, 116, 139, 117, 176, 199, 31, 4, 141, 14, 170, 140, 7, 211, 66, 134, 208, 13, 58, 224, 179, 234, 125, 245, 246, 46, 178, 62, 171, 7, 91, 99, 212, 29, 74, 12, 80, 246, 151, 109, 95, 172, 98, 1, 105, 172, 75, 142, 153, 196, 197, 211, 181, 9, 191, 83, 49, 136, 166, 166, 223, 200, 9, 228, 236, 34, 129, 217, 223, 234, 231, 247, 230, 237, 213, 224, 26, 94, 90, 151, 198, 169, 106, 93, 248, 232, 124, 154, 239, 111, 72, 240, 146, 169, 87, 68, 4, 93, 240, 108, 27, 100, 107, 60, 165, 149, 232, 37, 53, 112, 198, 98, 121, 145, 195, 133, 10, 39, 214 }, "User", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 2, new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(2725), "pringle@example.com", new byte[] { 112, 170, 8, 129, 67, 68, 246, 32, 188, 52, 79, 12, 106, 173, 177, 225, 42, 40, 17, 9, 165, 20, 27, 161, 198, 121, 61, 231, 177, 213, 232, 38, 72, 35, 75, 58, 255, 244, 125, 202, 191, 58, 25, 57, 155, 116, 64, 53, 107, 246, 240, 118, 194, 143, 183, 209, 90, 205, 208, 136, 58, 43, 169, 48 }, new byte[] { 171, 164, 89, 221, 75, 50, 13, 217, 87, 60, 154, 99, 70, 98, 177, 19, 196, 160, 234, 81, 184, 138, 77, 38, 66, 69, 38, 152, 169, 243, 44, 107, 58, 40, 150, 226, 144, 104, 64, 50, 30, 84, 113, 177, 49, 255, 188, 47, 227, 71, 30, 44, 163, 159, 18, 138, 56, 156, 23, 110, 119, 11, 68, 64, 92, 17, 175, 94, 6, 215, 13, 88, 123, 116, 161, 222, 214, 132, 21, 31, 190, 136, 4, 175, 87, 220, 60, 84, 241, 12, 127, 82, 115, 225, 145, 92, 206, 24, 231, 214, 144, 118, 50, 246, 120, 198, 153, 188, 138, 163, 147, 8, 115, 199, 19, 128, 134, 13, 131, 177, 222, 255, 176, 74, 67, 83, 143, 99 }, "User", "Pringleton" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 3, new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(2770), "john@dot.net", new byte[] { 126, 136, 189, 81, 224, 105, 122, 181, 45, 179, 33, 68, 108, 130, 86, 68, 154, 239, 253, 122, 46, 112, 111, 248, 142, 241, 2, 57, 59, 255, 18, 66, 177, 205, 8, 218, 147, 51, 32, 8, 132, 106, 108, 60, 195, 158, 169, 210, 13, 163, 42, 3, 60, 115, 130, 249, 38, 64, 233, 248, 86, 225, 13, 39 }, new byte[] { 102, 9, 221, 160, 95, 225, 90, 171, 189, 15, 215, 43, 65, 131, 117, 204, 190, 140, 254, 105, 2, 203, 54, 245, 55, 158, 43, 62, 220, 61, 117, 156, 243, 25, 198, 109, 35, 11, 86, 135, 11, 24, 6, 246, 8, 11, 163, 147, 45, 236, 6, 202, 105, 88, 231, 44, 165, 244, 142, 177, 95, 184, 237, 26, 104, 176, 209, 215, 218, 247, 140, 12, 246, 192, 8, 121, 238, 131, 23, 250, 134, 138, 59, 107, 92, 216, 215, 61, 145, 83, 129, 56, 189, 250, 34, 54, 46, 27, 113, 185, 216, 240, 183, 87, 28, 209, 72, 11, 88, 152, 11, 107, 178, 106, 203, 16, 251, 210, 246, 253, 174, 238, 204, 252, 27, 251, 106, 18 }, "User", "John Dotnet" });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 1, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 1, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3052), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 2, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 1, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3062), 0, "qui est esse", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 3, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 1, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3118), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 4, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 1, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3125), 0, "eum et est occaecati", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 5, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 1, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3132), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 6, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 1, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3138), 0, "dolorem eum magni eos aperiam quia", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 7, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 1, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3145), 0, "magnam facilis autem", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 8, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 1, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3152), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 9, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 2, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3159), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 10, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 2, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3165), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 11, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 2, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3172), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 12, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 2, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3179), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 13, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 2, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3185), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 14, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 2, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3192), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 15, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 2, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3199), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 16, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 2, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3206), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 17, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3212), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 18, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3219), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 19, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3226), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 20, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3232), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 21, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3239), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 22, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3245), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 23, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3252), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 24, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3259), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 25, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3265), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 26, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3272), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 27, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3279), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 28, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3285), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 29, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3292), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 30, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3299), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 31, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3306), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 32, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3312), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 33, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 5, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3319), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 34, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 5, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3326), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 35, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 5, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3332), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 36, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 5, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3339), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 37, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 5, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3345), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 38, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 5, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3352), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 39, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 5, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3359), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 40, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 5, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3366), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 41, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 6, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3373), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 42, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 6, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3380), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 43, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 6, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3386), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 44, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 6, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3393), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 45, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 6, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3399), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 46, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 6, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3406), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 47, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 6, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3413), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 48, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 6, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3419), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 49, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 7, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3426), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 50, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 7, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3432), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 51, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 7, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3439), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 52, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 7, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3446), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 53, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 7, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3452), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 54, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 7, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3459), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 55, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 7, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3466), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 56, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 7, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3472), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 57, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 8, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3479), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 58, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 8, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3485), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 59, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 8, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3492), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 60, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 8, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3499), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 61, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 8, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3505), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 62, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 8, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3512), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 63, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 8, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3519), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 64, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 8, new DateTime(2022, 6, 23, 20, 57, 39, 967, DateTimeKind.Local).AddTicks(3525), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 1, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3575), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 2, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3585), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 3, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3589), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 4, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3594), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 5, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3598), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 6, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3603), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 7, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3608), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 8, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3612), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 9, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3616), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 10, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3622), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 11, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3626), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 12, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3630), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 13, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3635), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 14, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3639), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 15, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3643), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 16, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3647), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 17, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3651), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 18, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3657), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 19, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3661), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 20, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3665), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 21, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3732), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 22, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3737), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 23, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3742), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 24, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3746), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 25, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3750), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 26, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3754), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 27, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3759), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 28, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3763), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 29, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3767), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 30, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3771), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 31, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3776), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 32, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3780), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 33, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3784), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 34, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3790), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 35, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3795), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 36, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3799), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 37, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3803), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 38, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3807), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 39, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3812), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 40, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3816), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 41, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3820), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 42, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3824), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 43, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3828), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 44, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3833), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 45, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3837), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 46, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3841), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 47, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3845), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 48, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3850), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 49, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3854), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 50, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3858), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 51, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3862), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 52, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3867), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 53, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3871), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 54, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3875), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 55, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3879), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 56, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3884), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 57, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3888), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 58, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3892), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 59, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3896), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 60, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3901), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 61, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3905), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 62, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3909), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 63, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3913), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 64, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 3, 57, 39, 967, DateTimeKind.Utc).AddTicks(3917), 1 });

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
