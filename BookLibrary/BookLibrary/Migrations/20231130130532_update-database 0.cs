using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabase0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LibraryAddDate", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 30, 14, 5, 32, 147, DateTimeKind.Local).AddTicks(8403), new DateTime(2023, 11, 30, 14, 5, 32, 147, DateTimeKind.Local).AddTicks(8392), new DateTime(2023, 11, 30, 14, 5, 32, 147, DateTimeKind.Local).AddTicks(8405) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LibraryAddDate", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 28, 17, 51, 53, 970, DateTimeKind.Local).AddTicks(5585), new DateTime(2023, 11, 28, 17, 51, 53, 970, DateTimeKind.Local).AddTicks(5569), new DateTime(2023, 11, 28, 17, 51, 53, 970, DateTimeKind.Local).AddTicks(5589) });
        }
    }
}
