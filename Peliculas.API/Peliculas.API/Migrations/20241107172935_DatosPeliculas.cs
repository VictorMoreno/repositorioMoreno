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
                    { 1, true, new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/peliculas/ea9fd07a-1fb5-4eb7-a01a-1c27266c2309.png", "Una épica historia sobre el exceso, la decadencia y los sueños rotos en el Hollywood de los años 20, donde la transición del cine mudo al sonoro sacude a la industria.", "Babylon", "https://www.youtube.com/watch?v=gBil8RpweBE&pp=ygUYYmFieWxvbiB0cmFpbGVyIGVzcGHDsW9s" },
                    { 2, true, new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/peliculas/14a89f1e-d997-46ec-ae77-37b43118b00c.jpg", "Un actor de televisión y su doble de riesgo se encuentran con los eventos de 1969 en Hollywood mientras las estrellas de cine se enfrentan a un cambio cultural.", "Érase una vez en… Hollywood", "https://www.youtube.com/watch?v=J0rFGJV3cYw" },
                    { 3, true, new DateTime(2019, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/peliculas/eecfa05e-7968-474a-93c4-3f5b24e5cb66.jpg", "Un astronauta viaja a los rincones más distantes del sistema solar para encontrar a su padre y resolver un misterio que amenaza la supervivencia de la Tierra.", "Ad Astra", "https://www.youtube.com/watch?v=2hy4clp3IMM" },
                    { 4, true, new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/peliculas/0acee9d1-94df-4229-aab0-bf7c308e2933.jpg", "Una escritora de novelas románticas es secuestrada por un millonario que busca un tesoro perdido en una isla remota, y es rescatada por su modelo de portada.", "La ciudad perdida", "https://www.youtube.com/watch?v=DWq5cjkxEQQ" },
                    { 5, false, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Dos solitarios se ven involucrados en el mismo trabajo, que pronto se convierte en una carrera por la supervivencia.", "Wolves", "https://www.youtube.com/watch?v=Ti_7suoHmRQ" },
                    { 6, true, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/peliculas/98e8356c-3214-454f-b6c5-81f82de778ff.jpg", "La segunda parte de la épica adaptación de Dune, donde Paul Atreides busca venganza y un legado que cambiará el universo.", "Dune: Parte dos", "https://www.youtube.com/watch?v=6OmJF6VjKMA" },
                    { 7, false, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/peliculas/aad70b69-1dd1-4b5a-8e4a-1941c00fe96f.jpg", "La siguiente entrega de la saga de ciencia ficción de Pandora, explorando nuevas regiones del planeta y enfrentándose a amenazas desconocidas.", "Avatar 3", "https://www.youtube.com/watch?v=YXtWPVFk5TQ" },
                    { 8, true, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/peliculas/ec9ebb58-73f3-4a0e-ae57-2e7de11da751.jpg", "Ethan Hunt continúa su lucha contra una nueva amenaza global en la segunda parte de esta entrega de alta tensión y acción.", "Misión: Imposible - Sentencia Mortal Parte Dos", "https://www.youtube.com/watch?v=8jRMVhGwy0M" },
                    { 9, true, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/peliculas/c2eb8dbc-9a1f-4bbe-a8d5-346999a51022.jpg", "Las heroínas del universo Marvel, Carol Danvers, Kamala Khan y Monica Rambeau, unen fuerzas para enfrentar una amenaza cósmica.", "The Marvels", "https://www.youtube.com/watch?v=gdSGIf8kbhg" },
                    { 10, true, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/peliculas/c900cffe-1828-46f1-9893-99b86ec064ab.png", "Arthur Fleck regresa como el Joker en una secuela que explora su relación con Harley Quinn y el oscuro descenso de ambos.", "Joker: locura de a dos", "https://www.youtube.com/watch?v=7SZfThvjt5I" }
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

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
