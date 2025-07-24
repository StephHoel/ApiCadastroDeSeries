using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Serie_Entity_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 23, 22, 27, 20, 350, DateTimeKind.Utc).AddTicks(9227), new DateTime(2025, 7, 23, 22, 27, 20, 350, DateTimeKind.Utc).AddTicks(9385) });
        }
    }
}
