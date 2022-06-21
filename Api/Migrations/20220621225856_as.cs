using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpScape.Api.Migrations
{
    public partial class @as : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: new Guid("22b83555-4112-4335-a229-44cb3c7daa77"));

            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: new Guid("61464988-a9df-46f9-a348-1d316b311a15"));

            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: new Guid("da877f9c-6bd8-4795-b10a-8215c1c92e1c"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("13d6f6c5-e0b8-401a-9d3a-4efe6043e1f7"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("31bd64c3-fe65-480f-9d1e-272be2869a2d"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("3ccec0cf-1946-4711-ac7a-5c40d2e121c2"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("bdb89202-3824-4650-aa7a-26fc882a70c7"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("d246f695-2f24-45d1-b5e2-c39ff71eda6e"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("df3c26a2-86ee-416e-b932-09385e5b96b1"));

            migrationBuilder.DeleteData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: new Guid("feb7f143-8b8b-4245-8f09-d1099cc93583"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a8d7b4d-b46b-47ef-a118-0ab88330e846"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("689f74f1-5274-444c-ac60-c33babb2143e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7c720f9-48bd-4d6c-b234-e9cdfadd16b3"));

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { new Guid("4bae1f58-9a20-4d09-88a9-d319f416c4c7"), "Category Author 2", "Category Description 2", "Category Name 2" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { new Guid("5b0d08c2-bf6b-4711-98e7-ab0567d4244e"), "Category Author 1 ", "Category Description 1", "Category Name 1" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { new Guid("e27e288d-4065-4f65-9f67-e7b4a6830dcf"), "Category Author 3", "Category Description 3", "Category Name 3" });

            migrationBuilder.InsertData(
                table: "ForumThreads",
                columns: new[] { "Id", "Body", "CategoryId", "Created", "Replies", "Title", "UserId", "Views", "Votes" },
                values: new object[] { new Guid("dd74bfbb-1874-437b-9fe0-140846e90399"), " body 1", new Guid("61464988-a9df-46f9-a348-1d316b311a15"), new DateTime(2022, 6, 21, 18, 58, 56, 399, DateTimeKind.Local).AddTicks(2896), 0, "tr1", new Guid("a7c720f9-48bd-4d6c-b234-e9cdfadd16b3"), 0, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new Guid("2077c0a9-17c8-49cf-8ec5-3c0d0524b162"), new DateTime(2022, 6, 21, 18, 58, 56, 399, DateTimeKind.Local).AddTicks(1913), "ss1@ss.ss", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "ss1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new Guid("7dd53e52-ae89-4be2-995d-f730b509d90b"), new DateTime(2022, 6, 21, 18, 58, 56, 399, DateTimeKind.Local).AddTicks(1948), "ss3@ss.ss", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "ss3" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new Guid("d8b3c298-9915-4b79-8ebd-b01f39a7df05"), new DateTime(2022, 6, 21, 18, 58, 56, 399, DateTimeKind.Local).AddTicks(1928), "ss2@ss.ss", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "ss2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: new Guid("4bae1f58-9a20-4d09-88a9-d319f416c4c7"));

            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: new Guid("5b0d08c2-bf6b-4711-98e7-ab0567d4244e"));

            migrationBuilder.DeleteData(
                table: "ForumCategories",
                keyColumn: "Id",
                keyValue: new Guid("e27e288d-4065-4f65-9f67-e7b4a6830dcf"));

            migrationBuilder.DeleteData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: new Guid("dd74bfbb-1874-437b-9fe0-140846e90399"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2077c0a9-17c8-49cf-8ec5-3c0d0524b162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7dd53e52-ae89-4be2-995d-f730b509d90b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b3c298-9915-4b79-8ebd-b01f39a7df05"));

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { new Guid("22b83555-4112-4335-a229-44cb3c7daa77"), "Category Author 1 ", "Category Description 1", "Category Name 1" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { new Guid("61464988-a9df-46f9-a348-1d316b311a15"), "Category Author 3", "Category Description 3", "Category Name 3" });

            migrationBuilder.InsertData(
                table: "ForumCategories",
                columns: new[] { "Id", "ForumCategoryAuthor", "ForumCategoryDescription", "ForumCategoryName" },
                values: new object[] { new Guid("da877f9c-6bd8-4795-b10a-8215c1c92e1c"), "Category Author 2", "Category Description 2", "Category Name 2" });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { new Guid("13d6f6c5-e0b8-401a-9d3a-4efe6043e1f7"), new Guid("00000000-0000-0000-0000-000000000000"), "post7  Body", "post7 title", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { new Guid("31bd64c3-fe65-480f-9d1e-272be2869a2d"), new Guid("00000000-0000-0000-0000-000000000000"), "post3  Body", "post3 title", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { new Guid("3ccec0cf-1946-4711-ac7a-5c40d2e121c2"), new Guid("00000000-0000-0000-0000-000000000000"), "post1  Body", "post1 title", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { new Guid("bdb89202-3824-4650-aa7a-26fc882a70c7"), new Guid("00000000-0000-0000-0000-000000000000"), "post2  Body", "post2 title", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { new Guid("d246f695-2f24-45d1-b5e2-c39ff71eda6e"), new Guid("00000000-0000-0000-0000-000000000000"), "post4  Body", "post4 title", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { new Guid("df3c26a2-86ee-416e-b932-09385e5b96b1"), new Guid("00000000-0000-0000-0000-000000000000"), "post5  Body", "post5 title", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ForumPosts",
                columns: new[] { "Id", "ForumAuthorId", "ForumPostBody", "ForumPostTitle", "ForumThreadId" },
                values: new object[] { new Guid("feb7f143-8b8b-4245-8f09-d1099cc93583"), new Guid("00000000-0000-0000-0000-000000000000"), "post6  Body", "post6 title", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new Guid("2a8d7b4d-b46b-47ef-a118-0ab88330e846"), new DateTime(2022, 6, 21, 18, 51, 11, 821, DateTimeKind.Local).AddTicks(563), "ss2@ss.ss", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "ss2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new Guid("689f74f1-5274-444c-ac60-c33babb2143e"), new DateTime(2022, 6, 21, 18, 51, 11, 821, DateTimeKind.Local).AddTicks(592), "ss3@ss.ss", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "ss3" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new Guid("a7c720f9-48bd-4d6c-b234-e9cdfadd16b3"), new DateTime(2022, 6, 21, 18, 51, 11, 821, DateTimeKind.Local).AddTicks(549), "ss1@ss.ss", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "ss1" });
        }
    }
}
