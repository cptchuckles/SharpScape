using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpScape.Api.Migrations
{
    public partial class UserRefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2022, 7, 5, 15, 20, 54, 484, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt", "RefreshToken" },
                values: new object[] { new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(280), new byte[] { 27, 123, 141, 204, 241, 156, 166, 162, 151, 148, 177, 214, 140, 129, 105, 19, 35, 252, 187, 186, 73, 19, 207, 13, 150, 185, 103, 200, 6, 200, 230, 100, 252, 170, 248, 192, 42, 108, 6, 229, 208, 117, 116, 37, 92, 233, 8, 116, 109, 159, 133, 192, 17, 254, 138, 36, 252, 30, 75, 55, 105, 19, 205, 210 }, new byte[] { 222, 199, 162, 228, 60, 177, 50, 192, 37, 58, 189, 187, 242, 124, 50, 65, 94, 155, 25, 71, 37, 107, 46, 141, 133, 162, 78, 34, 97, 210, 57, 114, 51, 117, 212, 136, 19, 66, 101, 24, 249, 154, 18, 45, 167, 97, 81, 59, 120, 228, 8, 234, 174, 117, 194, 63, 67, 22, 190, 167, 48, 226, 51, 29, 132, 106, 145, 53, 51, 239, 206, 206, 151, 189, 77, 174, 70, 36, 52, 118, 15, 231, 92, 251, 170, 102, 27, 123, 86, 101, 219, 145, 188, 45, 146, 60, 88, 50, 191, 77, 245, 81, 244, 210, 82, 49, 60, 183, 54, 58, 17, 134, 187, 177, 140, 146, 118, 187, 221, 211, 197, 106, 75, 216, 220, 67, 45, 218 }, "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt", "RefreshToken" },
                values: new object[] { new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(598), new byte[] { 210, 67, 204, 231, 29, 74, 111, 142, 238, 93, 89, 134, 7, 9, 34, 28, 222, 240, 196, 135, 179, 249, 202, 37, 6, 118, 192, 100, 67, 128, 65, 176, 10, 128, 229, 1, 152, 101, 38, 137, 93, 137, 157, 49, 192, 57, 5, 89, 127, 40, 114, 117, 221, 107, 172, 92, 100, 83, 255, 52, 40, 150, 133, 125 }, new byte[] { 62, 118, 192, 184, 48, 81, 130, 208, 55, 108, 175, 82, 150, 31, 72, 234, 251, 250, 23, 70, 81, 44, 22, 107, 83, 23, 25, 118, 121, 141, 45, 103, 241, 233, 196, 242, 39, 86, 67, 148, 49, 196, 82, 201, 195, 174, 136, 50, 70, 221, 151, 28, 0, 236, 139, 6, 221, 172, 205, 189, 154, 116, 46, 116, 154, 12, 133, 219, 3, 151, 33, 112, 113, 60, 150, 37, 33, 86, 166, 28, 103, 96, 65, 208, 196, 157, 38, 226, 141, 82, 80, 82, 245, 94, 40, 112, 38, 91, 192, 39, 172, 163, 45, 49, 233, 95, 4, 87, 3, 111, 220, 109, 169, 5, 35, 215, 126, 211, 15, 137, 198, 98, 101, 48, 201, 44, 9, 11 }, "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt", "RefreshToken" },
                values: new object[] { new DateTime(2022, 7, 5, 21, 20, 54, 484, DateTimeKind.Utc).AddTicks(643), new byte[] { 37, 102, 175, 84, 137, 33, 30, 34, 140, 201, 196, 11, 57, 75, 81, 85, 132, 166, 43, 234, 25, 255, 202, 229, 252, 93, 73, 225, 51, 25, 206, 114, 17, 118, 77, 130, 64, 11, 228, 221, 143, 215, 35, 210, 141, 158, 94, 13, 99, 203, 174, 207, 235, 15, 127, 26, 16, 195, 203, 225, 74, 235, 172, 135 }, new byte[] { 8, 137, 60, 216, 149, 31, 103, 173, 21, 105, 62, 71, 109, 66, 208, 4, 101, 240, 253, 232, 201, 101, 164, 203, 64, 96, 78, 49, 89, 74, 179, 14, 110, 103, 4, 82, 122, 243, 151, 33, 17, 9, 209, 146, 9, 194, 225, 194, 81, 223, 200, 218, 107, 189, 16, 222, 147, 5, 154, 156, 127, 217, 157, 140, 87, 236, 167, 7, 36, 124, 226, 19, 74, 218, 118, 198, 162, 13, 137, 75, 188, 165, 210, 169, 82, 212, 193, 227, 91, 27, 250, 54, 36, 133, 31, 143, 165, 10, 57, 109, 208, 235, 14, 164, 235, 114, 83, 153, 95, 101, 186, 252, 191, 159, 42, 173, 160, 37, 35, 77, 22, 93, 4, 215, 84, 177, 163, 18 }, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "ForumPosts",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2022, 6, 28, 15, 22, 32, 466, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 465, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "ForumThreads",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: new DateTime(2022, 6, 28, 11, 22, 32, 466, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 15, 22, 32, 465, DateTimeKind.Utc).AddTicks(9167), new byte[] { 134, 206, 227, 249, 140, 186, 223, 76, 66, 160, 104, 238, 121, 42, 127, 183, 245, 79, 59, 247, 238, 204, 24, 6, 45, 27, 101, 216, 47, 190, 161, 168, 172, 234, 130, 166, 227, 45, 122, 59, 142, 230, 176, 160, 80, 101, 3, 65, 199, 12, 76, 126, 125, 220, 244, 101, 105, 141, 73, 224, 177, 115, 172, 167 }, new byte[] { 48, 64, 134, 47, 89, 215, 123, 84, 101, 126, 124, 66, 88, 135, 26, 58, 218, 190, 93, 246, 230, 248, 11, 104, 116, 11, 195, 211, 250, 208, 112, 193, 18, 18, 5, 250, 118, 233, 255, 177, 80, 131, 152, 131, 33, 190, 20, 131, 243, 48, 245, 25, 38, 36, 146, 151, 145, 213, 42, 103, 125, 4, 44, 19, 222, 180, 74, 69, 150, 16, 182, 39, 142, 47, 169, 191, 111, 162, 201, 214, 246, 96, 12, 230, 231, 70, 133, 186, 185, 210, 219, 1, 106, 142, 109, 82, 124, 132, 210, 96, 69, 45, 43, 132, 213, 179, 139, 122, 67, 12, 164, 221, 169, 225, 125, 86, 68, 237, 163, 34, 184, 247, 155, 179, 245, 132, 39, 177 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 15, 22, 32, 465, DateTimeKind.Utc).AddTicks(9516), new byte[] { 83, 114, 10, 254, 115, 85, 136, 152, 5, 150, 101, 5, 55, 18, 223, 122, 106, 241, 67, 14, 183, 59, 18, 170, 150, 115, 53, 126, 226, 55, 36, 73, 151, 220, 75, 112, 145, 160, 225, 1, 99, 125, 115, 232, 25, 213, 101, 230, 188, 110, 150, 178, 51, 81, 158, 191, 141, 227, 138, 197, 197, 140, 213, 61 }, new byte[] { 125, 10, 96, 77, 228, 213, 133, 251, 6, 230, 130, 153, 109, 201, 234, 65, 255, 25, 233, 69, 91, 51, 226, 198, 98, 149, 120, 35, 11, 31, 165, 154, 62, 59, 187, 179, 198, 140, 99, 157, 175, 173, 148, 98, 156, 177, 95, 194, 191, 72, 67, 172, 181, 200, 62, 153, 50, 228, 220, 173, 170, 237, 17, 121, 250, 129, 74, 6, 133, 116, 155, 88, 62, 103, 166, 243, 165, 68, 29, 59, 20, 64, 88, 174, 147, 181, 206, 81, 246, 60, 113, 38, 195, 165, 1, 26, 0, 71, 127, 205, 102, 59, 133, 157, 52, 235, 81, 208, 95, 153, 177, 87, 187, 113, 192, 35, 229, 150, 227, 183, 55, 170, 43, 162, 211, 176, 80, 156 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 15, 22, 32, 465, DateTimeKind.Utc).AddTicks(9565), new byte[] { 198, 190, 61, 102, 86, 182, 198, 217, 204, 240, 66, 71, 204, 111, 234, 60, 43, 66, 35, 208, 184, 24, 206, 48, 132, 59, 38, 191, 154, 7, 240, 167, 204, 41, 137, 101, 249, 158, 144, 212, 61, 93, 74, 137, 84, 45, 60, 225, 51, 70, 114, 242, 182, 109, 203, 216, 161, 246, 34, 31, 208, 220, 54, 119 }, new byte[] { 139, 65, 199, 107, 190, 227, 75, 209, 218, 217, 24, 104, 39, 52, 186, 79, 138, 153, 187, 10, 43, 156, 199, 93, 65, 219, 86, 83, 243, 118, 135, 199, 166, 6, 117, 249, 204, 1, 97, 86, 201, 26, 88, 1, 196, 179, 226, 138, 74, 180, 238, 133, 141, 35, 21, 61, 9, 38, 234, 52, 141, 255, 156, 164, 34, 254, 9, 157, 237, 198, 180, 96, 253, 235, 40, 19, 59, 103, 49, 162, 138, 224, 62, 102, 41, 19, 201, 214, 63, 66, 213, 34, 102, 55, 239, 101, 214, 173, 172, 103, 247, 79, 139, 180, 72, 78, 164, 147, 135, 60, 193, 213, 47, 111, 217, 57, 14, 111, 223, 130, 135, 7, 140, 66, 113, 56, 227, 201 } });
        }
    }
}
