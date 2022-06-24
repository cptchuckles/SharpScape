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
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(4838), "admin@sharpscape.net", new byte[] { 22, 201, 72, 117, 196, 20, 145, 161, 43, 24, 53, 92, 76, 205, 203, 142, 106, 84, 58, 228, 209, 75, 33, 248, 26, 151, 198, 215, 169, 123, 233, 200, 92, 52, 98, 223, 167, 152, 218, 98, 80, 46, 83, 220, 248, 61, 2, 28, 147, 183, 204, 117, 110, 228, 82, 84, 82, 192, 41, 237, 214, 85, 210, 102 }, new byte[] { 146, 227, 87, 185, 27, 246, 27, 221, 254, 190, 63, 188, 7, 30, 210, 195, 44, 168, 168, 224, 119, 229, 206, 79, 240, 195, 181, 181, 188, 164, 40, 212, 185, 227, 60, 15, 135, 164, 153, 162, 189, 253, 113, 53, 4, 255, 193, 69, 30, 148, 83, 242, 35, 247, 57, 32, 107, 204, 223, 83, 7, 176, 182, 51, 114, 101, 12, 215, 207, 44, 19, 45, 173, 228, 121, 255, 97, 12, 26, 156, 88, 209, 2, 222, 173, 82, 218, 130, 63, 213, 62, 68, 157, 164, 220, 81, 11, 13, 222, 68, 209, 231, 13, 161, 129, 105, 231, 40, 77, 112, 75, 101, 251, 171, 73, 190, 44, 99, 192, 11, 182, 5, 59, 190, 237, 40, 213, 31 }, "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5131), "pringle@example.com", new byte[] { 174, 196, 134, 234, 78, 163, 220, 94, 69, 164, 94, 4, 21, 47, 198, 231, 129, 79, 70, 76, 255, 114, 22, 210, 161, 67, 3, 249, 42, 220, 24, 80, 174, 119, 139, 67, 224, 66, 160, 59, 161, 170, 41, 242, 27, 229, 4, 33, 95, 251, 135, 115, 203, 208, 207, 246, 225, 152, 236, 183, 84, 219, 153, 154 }, new byte[] { 16, 231, 125, 224, 2, 243, 128, 73, 208, 120, 93, 28, 139, 91, 110, 87, 57, 96, 15, 18, 125, 121, 233, 138, 150, 191, 237, 129, 151, 252, 96, 129, 94, 135, 31, 60, 48, 184, 115, 183, 33, 204, 2, 211, 160, 156, 124, 182, 66, 23, 20, 15, 225, 58, 110, 66, 162, 43, 158, 155, 65, 186, 19, 2, 44, 210, 6, 228, 77, 181, 161, 31, 110, 213, 197, 10, 75, 245, 185, 46, 11, 180, 93, 71, 167, 75, 176, 227, 186, 68, 228, 79, 50, 180, 217, 83, 235, 175, 129, 77, 247, 143, 225, 132, 30, 164, 167, 122, 184, 178, 110, 133, 10, 253, 242, 112, 207, 9, 12, 199, 187, 35, 202, 76, 28, 87, 142, 159 }, "Pringleton" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 3, new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5176), "john@dot.net", new byte[] { 253, 28, 68, 201, 175, 236, 221, 22, 169, 179, 2, 171, 45, 38, 18, 228, 160, 84, 107, 23, 147, 6, 175, 55, 163, 46, 2, 188, 59, 107, 182, 135, 97, 129, 149, 168, 209, 77, 224, 142, 123, 36, 165, 242, 116, 254, 236, 163, 255, 45, 123, 130, 186, 97, 240, 201, 213, 127, 105, 158, 114, 74, 35, 6 }, new byte[] { 8, 215, 161, 142, 141, 189, 197, 126, 174, 186, 53, 45, 34, 188, 46, 0, 99, 1, 188, 34, 208, 194, 213, 154, 224, 170, 137, 142, 97, 179, 87, 8, 35, 130, 160, 195, 170, 129, 134, 106, 185, 181, 61, 110, 242, 67, 3, 108, 1, 116, 67, 129, 169, 58, 131, 61, 75, 248, 132, 170, 153, 83, 250, 244, 124, 212, 89, 55, 237, 4, 166, 125, 135, 77, 80, 47, 239, 213, 49, 153, 94, 37, 133, 32, 245, 198, 19, 99, 171, 222, 41, 104, 38, 117, 228, 187, 253, 252, 67, 213, 234, 166, 62, 191, 203, 134, 211, 2, 169, 161, 177, 98, 53, 57, 128, 34, 29, 253, 48, 142, 146, 40, 91, 139, 184, 176, 144, 159 }, "John Dotnet" });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 1, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 1, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5463), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 2, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 1, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5470), 0, "qui est esse", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 3, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 1, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5477), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 4, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 1, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5484), 0, "eum et est occaecati", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 5, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 1, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5491), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 6, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 1, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5498), 0, "dolorem eum magni eos aperiam quia", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 7, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 1, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5504), 0, "magnam facilis autem", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 8, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 1, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5512), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 9, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 2, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5519), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 10, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 2, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5526), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 11, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 2, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5532), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 12, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 2, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5539), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 13, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 2, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5546), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 14, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 2, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5552), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 15, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 2, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5559), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 16, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 2, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5566), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 17, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5572), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 18, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5579), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 19, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5585), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 20, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5592), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 21, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5599), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 22, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5605), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 23, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5612), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 24, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5618), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 25, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5625), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 26, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5632), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 27, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5638), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 28, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5645), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 29, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5652), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 30, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5658), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 31, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5665), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 32, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5671), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 33, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 5, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5678), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 34, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 5, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5684), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 35, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 5, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5691), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 36, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 5, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5697), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 37, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 5, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5704), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 38, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 5, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5711), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 39, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 5, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5717), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 40, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 5, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5724), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 41, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 6, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5730), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 42, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 6, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5737), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 43, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 6, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5744), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 44, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 6, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5750), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 45, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 6, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5757), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 46, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 6, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5763), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 47, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 6, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5770), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 48, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 6, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5777), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 49, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 7, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5783), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 50, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 7, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5790), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 51, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 7, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5796), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 52, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 7, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5803), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 53, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 7, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5809), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 54, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 7, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5816), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 55, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 7, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5823), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 56, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 7, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5829), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 57, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 8, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5836), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 58, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 8, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5843), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 59, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 8, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5849), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 60, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 8, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5856), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 61, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 8, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5862), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 62, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 8, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5869), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 63, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 8, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5875), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 64, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 8, new DateTime(2022, 6, 23, 19, 5, 57, 193, DateTimeKind.Local).AddTicks(5882), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 1, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5926), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 2, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5935), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 3, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5940), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 4, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5945), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 5, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5949), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 6, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5954), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 7, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5959), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 8, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5963), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 9, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(5994), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 10, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6001), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 11, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6005), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 12, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6009), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 13, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6013), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 14, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6018), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 15, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6022), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 16, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6026), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 17, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6030), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 18, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6036), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 19, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6040), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 20, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6044), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 21, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6049), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 22, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6053), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 23, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6057), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 24, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6061), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 25, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6066), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 26, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6070), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 27, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6074), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 28, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6078), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 29, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6083), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 30, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6087), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 31, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6091), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 32, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6095), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 33, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6099), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 34, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6105), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 35, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6109), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 36, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6114), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 37, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6118), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 38, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6122), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 39, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6126), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 40, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6131), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 41, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6135), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 42, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6139), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 43, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6143), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 44, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6147), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 45, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6152), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 46, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6156), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 47, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6160), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 48, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6164), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 49, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6169), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 50, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6173), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 51, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6177), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 52, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6181), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 53, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6185), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 54, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6190), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 55, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6194), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 56, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6198), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 57, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6202), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 58, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6207), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 59, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6211), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 60, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6215), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 61, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6219), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 62, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6224), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 63, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6228), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 64, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 24, 2, 5, 57, 193, DateTimeKind.Utc).AddTicks(6232), 1 });

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
