#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Peliculas.API.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class NuevasPeliculasCine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PeliculasCines",
                columns: new[] { "CineId", "PeliculaId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 3, 1 },
                    { 3, 6 },
                    { 4, 6 },
                    { 5, 3 },
                    { 7, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 7, 3 });
        }
    }
}
