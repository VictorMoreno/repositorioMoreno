using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Peliculas.API.Migrations
{
    /// <inheritdoc />
    public partial class DatosPeliculas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "EnCines", "FechaLanzamiento", "Poster", "Resumen", "Titulo", "Trailer" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Una épica historia sobre el exceso, la decadencia y los sueños rotos en el Hollywood de los años 20, donde la transición del cine mudo al sonoro sacude a la industria.", "Babylon", "https://www.youtube.com/watch?v=hf5faotVKmo" },
                    { 2, true, new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Un actor de televisión y su doble de riesgo se encuentran con los eventos de 1969 en Hollywood mientras las estrellas de cine se enfrentan a un cambio cultural.", "Once Upon a Time in Hollywood", "https://www.youtube.com/watch?v=ELeMaP8EPAA" },
                    { 3, true, new DateTime(2019, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Un astronauta viaja a los rincones más distantes del sistema solar para encontrar a su padre y resolver un misterio que amenaza la supervivencia de la Tierra.", "Ad Astra", "https://www.youtube.com/watch?v=J5VAs99gJjY" },
                    { 4, true, new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Una escritora de novelas románticas es secuestrada por un millonario que busca un tesoro perdido en una isla remota, y es rescatada por su modelo de portada.", "The Lost City", "https://www.youtube.com/watch?v=mfjZHsWqL1g" },
                    { 5, false, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Dos solitarios se ven involucrados en el mismo trabajo, que pronto se convierte en una carrera por la supervivencia.", "Wolves", "https://www.youtube.com/watch?v=example" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
