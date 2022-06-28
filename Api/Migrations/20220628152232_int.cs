using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpScape.Api.Migrations
{
    public partial class @int : Migration
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
                values: new object[] { 1, new DateTime(2022, 6, 28, 15, 22, 32, 465, DateTimeKind.Utc).AddTicks(9167), "admin@sharpscape.net", new byte[] { 134, 206, 227, 249, 140, 186, 223, 76, 66, 160, 104, 238, 121, 42, 127, 183, 245, 79, 59, 247, 238, 204, 24, 6, 45, 27, 101, 216, 47, 190, 161, 168, 172, 234, 130, 166, 227, 45, 122, 59, 142, 230, 176, 160, 80, 101, 3, 65, 199, 12, 76, 126, 125, 220, 244, 101, 105, 141, 73, 224, 177, 115, 172, 167 }, new byte[] { 48, 64, 134, 47, 89, 215, 123, 84, 101, 126, 124, 66, 88, 135, 26, 58, 218, 190, 93, 246, 230, 248, 11, 104, 116, 11, 195, 211, 250, 208, 112, 193, 18, 18, 5, 250, 118, 233, 255, 177, 80, 131, 152, 131, 33, 190, 20, 131, 243, 48, 245, 25, 38, 36, 146, 151, 145, 213, 42, 103, 125, 4, 44, 19, 222, 180, 74, 69, 150, 16, 182, 39, 142, 47, 169, 191, 111, 162, 201, 214, 246, 96, 12, 230, 231, 70, 133, 186, 185, 210, 219, 1, 106, 142, 109, 82, 124, 132, 210, 96, 69, 45, 43, 132, 213, 179, 139, 122, 67, 12, 164, 221, 169, 225, 125, 86, 68, 237, 163, 34, 184, 247, 155, 179, 245, 132, 39, 177 }, "User", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 2, new DateTime(2022, 6, 28, 15, 22, 32, 465, DateTimeKind.Utc).AddTicks(9516), "pringle@example.com", new byte[] { 83, 114, 10, 254, 115, 85, 136, 152, 5, 150, 101, 5, 55, 18, 223, 122, 106, 241, 67, 14, 183, 59, 18, 170, 150, 115, 53, 126, 226, 55, 36, 73, 151, 220, 75, 112, 145, 160, 225, 1, 99, 125, 115, 232, 25, 213, 101, 230, 188, 110, 150, 178, 51, 81, 158, 191, 141, 227, 138, 197, 197, 140, 213, 61 }, new byte[] { 125, 10, 96, 77, 228, 213, 133, 251, 6, 230, 130, 153, 109, 201, 234, 65, 255, 25, 233, 69, 91, 51, 226, 198, 98, 149, 120, 35, 11, 31, 165, 154, 62, 59, 187, 179, 198, 140, 99, 157, 175, 173, 148, 98, 156, 177, 95, 194, 191, 72, 67, 172, 181, 200, 62, 153, 50, 228, 220, 173, 170, 237, 17, 121, 250, 129, 74, 6, 133, 116, 155, 88, 62, 103, 166, 243, 165, 68, 29, 59, 20, 64, 88, 174, 147, 181, 206, 81, 246, 60, 113, 38, 195, 165, 1, 26, 0, 71, 127, 205, 102, 59, 133, 157, 52, 235, 81, 208, 95, 153, 177, 87, 187, 113, 192, 35, 229, 150, 227, 183, 55, 170, 43, 162, 211, 176, 80, 156 }, "User", "Pringleton" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 3, new DateTime(2022, 6, 28, 15, 22, 32, 465, DateTimeKind.Utc).AddTicks(9565), "john@dot.net", new byte[] { 198, 190, 61, 102, 86, 182, 198, 217, 204, 240, 66, 71, 204, 111, 234, 60, 43, 66, 35, 208, 184, 24, 206, 48, 132, 59, 38, 191, 154, 7, 240, 167, 204, 41, 137, 101, 249, 158, 144, 212, 61, 93, 74, 137, 84, 45, 60, 225, 51, 70, 114, 242, 182, 109, 203, 216, 161, 246, 34, 31, 208, 220, 54, 119 }, new byte[] { 139, 65, 199, 107, 190, 227, 75, 209, 218, 217, 24, 104, 39, 52, 186, 79, 138, 153, 187, 10, 43, 156, 199, 93, 65, 219, 86, 83, 243, 118, 135, 199, 166, 6, 117, 249, 204, 1, 97, 86, 201, 26, 88, 1, 196, 179, 226, 138, 74, 180, 238, 133, 141, 35, 21, 61, 9, 38, 234, 52, 141, 255, 156, 164, 34, 254, 9, 157, 237, 198, 180, 96, 253, 235, 40, 19, 59, 103, 49, 162, 138, 224, 62, 102, 41, 19, 201, 214, 63, 66, 213, 34, 102, 55, 239, 101, 214, 173, 172, 103, 247, 79, 139, 180, 72, 78, 164, 147, 135, 60, 193, 213, 47, 111, 217, 57, 14, 111, 223, 130, 135, 7, 140, 66, 113, 56, 227, 201 }, "User", "John Dotnet" });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 1, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 1, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9821), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 2, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 1, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9828), 0, "qui est esse", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 3, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 1, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9833), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 4, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 1, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9839), 0, "eum et est occaecati", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 5, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 1, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9844), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 6, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 1, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9849), 0, "dolorem eum magni eos aperiam quia", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 7, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 1, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9854), 0, "magnam facilis autem", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 8, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 1, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9860), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 9, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 2, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9865), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 10, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 2, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9870), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 11, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 2, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9876), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 12, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 2, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9881), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 13, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 2, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9886), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 14, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 2, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9891), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 15, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 2, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9897), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 16, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 2, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9902), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 17, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9908), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 18, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9913), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 19, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9919), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 20, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9924), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 21, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9929), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 22, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9935), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 23, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9940), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 24, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9946), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 25, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9951), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 26, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9956), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 27, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9962), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 28, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9967), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 29, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9972), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 30, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9977), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 31, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9983), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 32, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 3, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9989), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 33, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 5, new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9995), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 34, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 5, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(1), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 35, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 5, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(7), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 36, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 5, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(12), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 37, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 5, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(17), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 38, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 5, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(23), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 39, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 5, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(28), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 40, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 5, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(33), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 41, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 6, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(38), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 42, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 6, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(44), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 43, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 6, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(49), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 44, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 6, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(54), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 45, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 6, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(60), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 46, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 6, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(65), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 47, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 6, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(71), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 48, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 6, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(77), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 49, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 7, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(82), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 50, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 7, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(87), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 51, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 7, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(93), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 52, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 7, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(143), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 53, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 7, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(149), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 54, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 7, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(154), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 55, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 7, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(160), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 56, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 7, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(165), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 57, "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", 8, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(204), 0, "sunt aut facere repellat provident occaecati excepturi optio reprehenderit", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 58, "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla", 8, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(210), 0, "qui est esse", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 59, "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut", 8, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(215), 0, "ea molestias quasi exercitationem repellat qui ipsa sit aut", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 60, "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit", 8, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(221), 0, "eum et est occaecati", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 61, "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque", 8, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(226), 0, "nesciunt quas odio", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 62, "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae", 8, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(231), 0, "dolorem eum magni eos aperiam quia", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 63, "dolore placeat quibusdam ea quo vitae\nmagni quis enim qui quis quo nemo aut saepe\nquidem repellat excepturi ut quia\nsunt ut sequi eos ea sed quas", 8, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(236), 0, "magnam facilis autem", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 64, "dignissimos aperiam dolorem qui eum\nfacilis quibusdam animi sint suscipit qui sint possimus cum\nquaerat magni maiores excepturi\nipsam ut commodi dolor voluptatum modi aut vitae", 8, new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(242), 0, "dolorem dolore est ipsam", 2, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 1, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(288), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 2, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(296), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 3, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(300), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 4, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(304), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 5, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(307), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 6, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(312), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 7, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(316), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 8, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(320), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 9, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(323), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 10, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(328), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 11, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(332), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 12, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(335), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 13, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(339), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 14, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(342), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 15, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(346), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 16, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(349), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 17, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(353), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 18, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(357), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 19, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(362), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 20, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(365), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 21, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(369), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 22, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(372), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 23, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(376), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 24, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(379), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 25, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(382), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 26, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(386), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 27, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(389), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 28, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(393), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 29, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(396), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 30, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(399), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 31, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(403), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 32, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(406), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 33, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(410), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 34, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(414), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 35, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(418), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 36, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(422), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 37, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(425), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 38, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(429), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 39, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(432), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 40, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(436), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 41, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(439), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 42, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(442), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 43, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(446), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 44, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(450), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 45, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(453), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 46, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(456), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 47, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(460), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 48, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(463), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 49, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(466), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 50, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(470), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 51, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(473), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 52, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(477), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 53, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(480), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 54, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(483), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 55, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(487), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 56, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(490), 1 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 57, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(494), 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 58, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(497), 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 59, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(500), 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 60, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(504), 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 61, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(507), 6 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 62, 3, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(511), 7 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 63, 1, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(514), 8 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Created", "ThreadId" },
                values: new object[] { 64, 2, "est natus enim nihil est dolore omnis voluptatem numquam\net omnis occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum voluptatem reiciendis et", new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(518), 1 });

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
