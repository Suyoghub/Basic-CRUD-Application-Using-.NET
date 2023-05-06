using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bulkybookweb.Migrations
{
    public partial class SeedCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "CreatedDateTime", "DisplayOrdr", "Name" },
                values: new object[] { 1, new DateTime(2023, 4, 29, 19, 26, 44, 8, DateTimeKind.Local).AddTicks(4635), 1, "Action" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "CreatedDateTime", "DisplayOrdr", "Name" },
                values: new object[] { 2, new DateTime(2023, 4, 29, 19, 26, 44, 8, DateTimeKind.Local).AddTicks(4647), 2, "Scifi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
