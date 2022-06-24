using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpScape.Api.Data.Migrations.Sqlite
{
    public partial class Users_AddColumn_Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 23, 22, 16, 54, 281, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 23, 22, 16, 54, 281, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 6, 23, 22, 16, 54, 281, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 6, 23, 22, 16, 54, 281, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Role" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 16, 54, 280, DateTimeKind.Local).AddTicks(9795), "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Role" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 16, 54, 280, DateTimeKind.Local).AddTicks(9802), "User" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Role" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 16, 54, 280, DateTimeKind.Local).AddTicks(9808), "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 22, 19, 17, 16, 390, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 22, 19, 17, 16, 390, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 6, 22, 19, 17, 16, 390, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 6, 22, 19, 17, 16, 390, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 22, 19, 17, 16, 390, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 22, 19, 17, 16, 390, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 22, 19, 17, 16, 390, DateTimeKind.Local).AddTicks(8634));
        }
    }
}
