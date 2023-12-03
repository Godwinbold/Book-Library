using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    /// <inheritdoc />
    public partial class antherMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl", "LibraryAddDate", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 28, 17, 51, 53, 970, DateTimeKind.Local).AddTicks(5585), null, new DateTime(2023, 11, 28, 17, 51, 53, 970, DateTimeKind.Local).AddTicks(5569), new DateTime(2023, 11, 28, 17, 51, 53, 970, DateTimeKind.Local).AddTicks(5589) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LibraryAddDate", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 36, 14, 773, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 11, 22, 11, 36, 14, 773, DateTimeKind.Local).AddTicks(9680), new DateTime(2023, 11, 22, 11, 36, 14, 773, DateTimeKind.Local).AddTicks(9712) });
        }
    }
}
