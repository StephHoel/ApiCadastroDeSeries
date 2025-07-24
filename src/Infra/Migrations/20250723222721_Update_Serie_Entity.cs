using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Update_Serie_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("b1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("c1111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("d1111111-1111-1111-1111-111111111111"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Series",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Series",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Series",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Series",
                keyColumn: "Id",
                keyValue: new Guid("a1111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 7, 23, 22, 27, 20, 350, DateTimeKind.Utc).AddTicks(9227), null, new DateTime(2025, 7, 23, 22, 27, 20, 350, DateTimeKind.Utc).AddTicks(9385) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Series");

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Genre", "Seasons", "Title" },
                values: new object[,]
                {
                    { new Guid("b1111111-1111-1111-1111-111111111111"), "[\"Crime\"]", 5, "Breaking Bad" },
                    { new Guid("c1111111-1111-1111-1111-111111111111"), "[\"Sci-Fi\"]", 4, "Stranger Things" },
                    { new Guid("d1111111-1111-1111-1111-111111111111"), "[\"Drama\"]", 6, "The Crown" }
                });
        }
    }
}
