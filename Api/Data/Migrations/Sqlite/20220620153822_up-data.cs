using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpScape.Api.Data.Migrations.Sqlite
{
    public partial class updata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumCategorys",
                keyColumn: "Id",
                keyValue: new Guid("5a6a324c-3f2f-43a4-a482-2fc2e4987303"));

            migrationBuilder.DeleteData(
                table: "ForumCategorys",
                keyColumn: "Id",
                keyValue: new Guid("c5656a1e-12e0-4043-9ed0-e3cf16cabdba"));

            migrationBuilder.DeleteData(
                table: "ForumCategorys",
                keyColumn: "Id",
                keyValue: new Guid("e69ce6f7-1534-46f7-9b1d-bdb053dc7292"));

            migrationBuilder.AddColumn<Guid>(
                name: "ForumCategoryId",
                table: "ForumThreads",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForumCategoryAuthor",
                table: "ForumCategorys",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ForumCategoryDescription",
                table: "ForumCategorys",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ForumCategoryName",
                table: "ForumCategorys",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "ForumCategorys",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { new Guid("1d45d377-770b-4f25-99bc-7993e69c5cb3"), "Category Author 1", "Category Description 1", "Category Name 1" });

            migrationBuilder.InsertData(
                table: "ForumCategorys",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { new Guid("5c616052-2596-4cc4-8a8b-1cab79c698c4"), "Category Author 3", "Category Description 3", "Category Name 3" });

            migrationBuilder.InsertData(
                table: "ForumCategorys",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { new Guid("b9878eed-e852-451a-a893-885b2d2fec68"), "Category Author 2", "Category Description 2", "Category Name 2" });

            migrationBuilder.CreateIndex(
                name: "IX_ForumThreads_ForumCategoryId",
                table: "ForumThreads",
                column: "ForumCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumThreads_ForumCategorys_ForumCategoryId",
                table: "ForumThreads",
                column: "ForumCategoryId",
                principalTable: "ForumCategorys",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumThreads_ForumCategorys_ForumCategoryId",
                table: "ForumThreads");

            migrationBuilder.DropIndex(
                name: "IX_ForumThreads_ForumCategoryId",
                table: "ForumThreads");

            migrationBuilder.DeleteData(
                table: "ForumCategorys",
                keyColumn: "Id",
                keyValue: new Guid("1d45d377-770b-4f25-99bc-7993e69c5cb3"));

            migrationBuilder.DeleteData(
                table: "ForumCategorys",
                keyColumn: "Id",
                keyValue: new Guid("5c616052-2596-4cc4-8a8b-1cab79c698c4"));

            migrationBuilder.DeleteData(
                table: "ForumCategorys",
                keyColumn: "Id",
                keyValue: new Guid("b9878eed-e852-451a-a893-885b2d2fec68"));

            migrationBuilder.DropColumn(
                name: "ForumCategoryId",
                table: "ForumThreads");

            migrationBuilder.DropColumn(
                name: "ForumCategoryAuthor",
                table: "ForumCategorys");

            migrationBuilder.DropColumn(
                name: "ForumCategoryDescription",
                table: "ForumCategorys");

            migrationBuilder.DropColumn(
                name: "ForumCategoryName",
                table: "ForumCategorys");

            migrationBuilder.InsertData(
                table: "ForumCategorys",
                column: "Id",
                value: new Guid("5a6a324c-3f2f-43a4-a482-2fc2e4987303"));

            migrationBuilder.InsertData(
                table: "ForumCategorys",
                column: "Id",
                value: new Guid("c5656a1e-12e0-4043-9ed0-e3cf16cabdba"));

            migrationBuilder.InsertData(
                table: "ForumCategorys",
                column: "Id",
                value: new Guid("e69ce6f7-1534-46f7-9b1d-bdb053dc7292"));
        }
    }
}
