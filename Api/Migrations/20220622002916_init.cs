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
                    ForumCategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    ForumCategoryDescription = table.Column<string>(type: "TEXT", nullable: false),
                    ForumCategoryAuthor = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ForumPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ForumPostTitle = table.Column<string>(type: "TEXT", nullable: false),
                    ForumPostBody = table.Column<string>(type: "TEXT", nullable: false),
                    ForumThreadId = table.Column<int>(type: "INTEGER", nullable: false),
                    ForumAuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPosts", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { 1, "Category Author 1 ", "Category Description 1", "Category Name 1" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { 2, "Category Author 2", "Category Description 2", "Category Name 2" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { 3, "Category Author 3", "Category Description 3", "Category Name 3" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new DateTime(2022, 6, 21, 20, 29, 16, 273, DateTimeKind.Local).AddTicks(6528), "ss1@ss.ss", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "ss1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new DateTime(2022, 6, 21, 20, 29, 16, 273, DateTimeKind.Local).AddTicks(6535), "ss2@ss.ss", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "ss2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 3, new DateTime(2022, 6, 21, 20, 29, 16, 273, DateTimeKind.Local).AddTicks(6540), "ss3@ss.ss", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "ss3" });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 5, " body 1", 2, new DateTime(2022, 6, 21, 20, 29, 16, 273, DateTimeKind.Local).AddTicks(6685), 0, "tr1", 2, 0, 0 });

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
