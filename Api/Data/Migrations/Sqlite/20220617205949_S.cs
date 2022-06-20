using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpScape.Api.Data.Migrations.Sqlite
{
    public partial class S : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumCategorys",
                column: "Id",
                value: new Guid("556073be-f19b-4f09-a928-41f4ca3f88b2"));

            migrationBuilder.InsertData(
                table: "ForumCategorys",
                column: "Id",
                value: new Guid("b89fc9f0-f242-4088-80c9-1c4c1696fc6a"));

            migrationBuilder.InsertData(
                table: "ForumCategorys",
                column: "Id",
                value: new Guid("c3429b33-bcb2-4dc3-9975-ab1dfcb026b3"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumCategorys",
                keyColumn: "Id",
                keyValue: new Guid("556073be-f19b-4f09-a928-41f4ca3f88b2"));

            migrationBuilder.DeleteData(
                table: "ForumCategorys",
                keyColumn: "Id",
                keyValue: new Guid("b89fc9f0-f242-4088-80c9-1c4c1696fc6a"));

            migrationBuilder.DeleteData(
                table: "ForumCategorys",
                keyColumn: "Id",
                keyValue: new Guid("c3429b33-bcb2-4dc3-9975-ab1dfcb026b3"));
        }
    }
}
