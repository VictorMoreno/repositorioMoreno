#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Peliculas.API.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class DatosActores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actores",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 1, "Leonardo DiCaprio es un actor y productor estadounidense conocido por películas como 'Titanic', 'Inception' y 'The Revenant'. Ganó un Óscar por 'The Revenant'.", new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/39c562aa-c83d-4bc7-97aa-8895dc46880c.jpg", "Leonardo DiCaprio" },
                    { 2, "Meryl Streep es una reconocida actriz estadounidense, famosa por su habilidad para interpretar distintos personajes. Ha ganado tres premios Óscar y es una de las actrices más nominadas en la historia del cine.", new DateTime(1949, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/ade14658-7f47-496a-ace0-7c1d0414f468.jpg", "Meryl Streep" },
                    { 3, "Robert De Niro es un actor y productor estadounidense, famoso por sus papeles en 'Taxi Driver', 'Raging Bull' y 'Goodfellas'. Ha ganado dos premios Óscar.", new DateTime(1943, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/b0ff03ae-86fa-426b-9ce2-9e4975678026.jpg", "Robert De Niro" },
                    { 4, "Scarlett Johansson es una actriz estadounidense conocida por su papel en el Universo Cinematográfico de Marvel como 'Black Widow' y en películas como 'Lost in Translation'.", new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/ef905ad6-7cb3-46d9-adfc-e2961efd0437.jpg", "Scarlett Johansson" },
                    { 5, "Tom Hanks es un actor y productor estadounidense conocido por sus papeles en 'Forrest Gump', 'Saving Private Ryan' y 'Cast Away'. Ha ganado dos premios Óscar consecutivos.", new DateTime(1956, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/91510ed1-a7dd-4592-bbc4-e3baa12285c0.jpg", "Tom Hanks" },
                    { 6, "Natalie Portman es una actriz y productora estadounidense-israelí, conocida por su papel en 'Black Swan', por el que ganó un Óscar, y su participación en la saga 'Star Wars'.", new DateTime(1981, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/3531dfef-80bd-4e62-b40b-d7f5e89ddb27.jpg", "Natalie Portman" },
                    { 7, "Brad Pitt es un actor y productor estadounidense famoso por sus papeles en 'Fight Club', 'Inglourious Basterds' y 'Once Upon a Time in Hollywood', por el que ganó un Óscar.", new DateTime(1963, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/fed532b0-86d5-4e3d-9978-cbaf00f53bd2.jpg", "Brad Pitt" },
                    { 8, "Emma Stone es una actriz estadounidense conocida por su papel en 'La La Land', por el cual ganó un Óscar. También es conocida por su trabajo en 'Easy A' y 'The Amazing Spider-Man'.", new DateTime(1988, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/626b3111-fd53-40f9-a88c-02dcc38587a2.jpg", "Emma Stone" },
                    { 9, "Morgan Freeman es un actor y narrador estadounidense conocido por su voz distintiva y papeles en 'The Shawshank Redemption', 'Se7en' y 'Driving Miss Daisy'. Ganó un Óscar en 2005.", new DateTime(1937, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/76ac4765-8bcd-4075-8bf2-25c601e0a891.jpeg", "Morgan Freeman" },
                    { 10, "Charlize Theron es una actriz y productora sudafricana conocida por su papel en 'Monster', por el que ganó un Óscar, y su actuación en películas de acción como 'Mad Max: Fury Road'.", new DateTime(1975, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/620ba7f7-38ac-4727-9a7c-8f3f7dcfb47e.jpg", "Charlize Theron" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
