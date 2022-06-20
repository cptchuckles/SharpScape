using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpScape.Api.Data.Migrations.Sqlite
{
    public partial class data_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
