using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpScape.Api.Migrations
{
    public partial class posr_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { 1, 1, "post1  Body", "post1 title", 2 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { 2, 1, "post2  Body", "post2 title", 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { 3, 1, "post3  Body", "post3 title", 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { 4, 2, "post4  Body", "post4 title", 3 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { 5, 2, "post5  Body", "post5 title", 4 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { 6, 3, "post6  Body", "post6 title", 5 });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { 7, 3, "post7  Body", "post7 title", 5 });

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 6, 21, 20, 36, 46, 319, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 2, " body 1", 3, new DateTime(2022, 6, 21, 20, 36, 46, 319, DateTimeKind.Local).AddTicks(3682), 0, "tr1", 3, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 3, " body 1", 1, new DateTime(2022, 6, 21, 20, 36, 46, 319, DateTimeKind.Local).AddTicks(3675), 0, "tr1", 1, 0, 0 });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { 4, " body 1", 2, new DateTime(2022, 6, 21, 20, 36, 46, 319, DateTimeKind.Local).AddTicks(3666), 0, "tr1", 1, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 21, 20, 36, 46, 319, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 21, 20, 36, 46, 319, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 21, 20, 36, 46, 319, DateTimeKind.Local).AddTicks(3408));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 6, 21, 20, 29, 16, 273, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 21, 20, 29, 16, 273, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 21, 20, 29, 16, 273, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 21, 20, 29, 16, 273, DateTimeKind.Local).AddTicks(6540));
        }
    }
}
