#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Peliculas.API.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class DatosPeliculasCines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PeliculasCines",
                columns: new[] { "CineId", "PeliculaId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 7 },
                    { 2, 5 },
                    { 3, 3 },
                    { 3, 9 },
                    { 4, 1 },
                    { 5, 6 },
                    { 5, 8 },
                    { 7, 4 },
                    { 7, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "PeliculasCines",
                keyColumns: new[] { "CineId", "PeliculaId" },
                keyValues: new object[] { 7, 10 });
        }
    }
}
