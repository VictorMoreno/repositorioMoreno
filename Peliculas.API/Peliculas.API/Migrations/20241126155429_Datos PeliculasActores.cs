using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Peliculas.API.Migrations
{
    /// <inheritdoc />
    public partial class DatosPeliculasActores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actores",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 11, "Margot Robbie es una actriz y productora australiana conocida por sus papeles en películas como 'The Wolf of Wall Street', 'I, Tonya' y 'Barbie'. Ha sido nominada a varios premios, incluyendo el Óscar, y es reconocida por su versatilidad en papeles dramáticos y cómicos.", new DateTime(1990, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/8FA42CB3-2A52-4C12-A5D6-EED127CA6139.jpg", "Margot Robbie" },
                    { 12, "Ruth Negga es una actriz irlandesa-etíope conocida por su actuación en 'Loving', por la que recibió una nominación al Óscar. También ha destacado en series como 'Preacher' y 'Agents of S.H.I.E.L.D.'.", new DateTime(1981, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/50D498BD-39F2-42C5-A6B8-781DA33CB01D.jpg", "Ruth Negga" },
                    { 13, "Tommy Lee Jones es un actor y director estadounidense ganador del Óscar, conocido por papeles en películas como 'Men in Black', 'No Country for Old Men' y 'The Fugitive'. Es reconocido por su carácter y estilo distintivo en la pantalla.", new DateTime(1946, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/01CF2324-A586-4A1E-9583-C4A35FFDA084.jpg", "Tommy Lee Jones" },
                    { 14, "Sandra Bullock es una actriz y productora estadounidense, conocida por su versatilidad en una amplia gama de géneros, desde la comedia en 'Miss Congeniality' hasta el drama en 'The Blind Side', película que le valió un Óscar. También ha sido aclamada por sus papeles en 'Gravity' y 'Bird Box'.", new DateTime(1964, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/9F0150C5-6584-45D0-9EFC-9E0F78B49BAF.jpg", "Sandra Bullock" },
                    { 15, "Channing Tatum es un actor, productor y bailarín estadounidense, conocido por sus papeles en películas como 'Magic Mike', 'Step Up' y '21 Jump Street'. Su habilidad para la danza le ha ayudado a destacarse, además de su presencia en comedias y dramas.", new DateTime(1980, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/ED6F7AB2-28AB-4AA1-8F0B-F988B4594D5F.jpg", "Channing Tatum" },
                    { 16, "George Clooney es un actor, director y productor estadounidense, reconocido mundialmente por su trabajo en películas como 'Ocean's Eleven', 'Gravity', 'The Descendants' y 'Up in the Air'. Ha ganado múltiples premios, incluidos los premios Óscar, y es conocido por su activismo y trabajo humanitario.", new DateTime(1961, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/74E76C1E-EC0E-4AB2-BA80-A83CE2385235.jpg", "George Clooney" },
                    { 17, "Timothée Chalamet es un actor estadounidense, conocido por sus papeles en 'Call Me by Your Name', 'Little Women', y su participación en 'Dune'. Aclamado por su habilidad actoral, Chalamet ha sido nominado a varios premios importantes, incluidos los premios Óscar.", new DateTime(1995, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/B5F73E68-8140-4904-9D25-C764CECD0199.jpg", "Timothée Chalamet" },
                    { 18, "Zendaya Maree Stoermer Coleman, conocida profesionalmente como Zendaya, es una actriz y cantante estadounidense famosa por su papel en la serie de Disney Channel 'Shake It Up' y su papel en películas como 'Spider-Man: Homecoming' y 'Dune'. Además de su carrera en la actuación, Zendaya es una influyente figura en la moda y activismo social.", new DateTime(1996, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/5D506761-8211-4C40-A4AB-CCC2582A335C.jpg", "Zendaya" },
                    { 19, "Cliff Curtis es un actor neozelandés conocido por sus roles en películas de acción y dramas. Ha trabajado en varias producciones importantes, incluyendo 'Training Day', 'The Dark Horse', y 'Avatar'. En la saga de Avatar, interpreta a Tonowari, el líder de la tribu de los Metkayina.", new DateTime(1968, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/FC2B363B-0FBE-44A3-94FD-9D08E5C72C51.jpg", "Cliff Curtis" },
                    { 20, "Kate Winslet es una actriz inglesa ganadora de múltiples premios, incluyendo un Óscar por su papel en 'The Reader'. Es conocida por su capacidad de adaptarse a roles diversos, como en 'Titanic', 'Eternal Sunshine of the Spotless Mind', y en la saga de Avatar como la Dr. Ronal.", new DateTime(1975, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/A77A6BEA-0FDD-49BE-83DB-93F6B81BEAC3.jpg", "Kate Winslet" },
                    { 21, "Hayley Atwell es una actriz británica conocida por su papel de Peggy Carter en el Universo Cinematográfico de Marvel. Su presencia en 'Misión: Imposible - Sentencia Mortal Parte Dos' marca una nueva colaboración en el cine de acción, donde interpreta a un personaje clave dentro de la trama.", new DateTime(1982, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/E4E6F0A2-BDEA-44C4-956A-D86E02CCFA45.jpg", "Hayley Atwell" },
                    { 22, "Tom Cruise es uno de los actores más famosos y exitosos de Hollywood, conocido por su papel icónico como Ethan Hunt en la saga 'Misión: Imposible'. Además de ser un actor destacado, ha sido productor de muchas de sus películas y es conocido por sus impresionantes acrobacias y dedicación a sus roles.", new DateTime(1962, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/7671EC80-98D6-403A-AEC7-4C8A3A7DE2E7.jpg", "Tom Cruise" },
                    { 23, "Iman Vellani es una joven actriz canadiense conocida por interpretar a Kamala Khan/Ms. Marvel en la serie de Disney+ 'Ms. Marvel'. 'The Marvels' es su participación en el Universo Cinematográfico de Marvel, donde compartirá pantalla con otras heroínas del MCU.", new DateTime(2002, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/DFD1D3B8-EE44-4B63-A335-B16CE508C80A.jpg", "Iman Vellani" },
                    { 24, "Teyonah Parris es una actriz estadounidense conocida por su papel como Monica Rambeau en la serie de Disney+ 'WandaVision' y ahora en 'The Marvels'. Parris ha sido aclamada por su trabajo en la televisión y el cine, destacándose por su versatilidad y talento.", new DateTime(1987, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/CC6C7B1C-BED7-434A-8F39-404077C11F5F.jpg", "Teyonah Parris" },
                    { 25, "Brie Larson es una actriz, directora y productora estadounidense conocida por su papel como Carol Danvers/Captain Marvel en el Universo Cinematográfico de Marvel. Ganó el Premio de la Academia a la Mejor Actriz por su actuación en 'Room'. Además de su carrera actoral, Larson también ha incursionado en la dirección de películas.", new DateTime(1989, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/54CEFD17-5189-46EE-81B1-AC93F0A42CAB.jpg", "Brie Larson" },
                    { 26, "Lady Gaga es una cantante, compositora y actriz estadounidense, conocida por su estilo musical ecléctico y su presencia en el escenario. Ha ganado múltiples premios, incluidos varios premios Grammy, y su actuación en 'A Star Is Born' (2018) le valió una nominación al Óscar. En 'Joker: Locura de a Dos', interpretará a Harley Quinn.", new DateTime(1986, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/DD1BAEBB-57E2-4D97-834E-79503110E782.jpg", "Lady Gaga" },
                    { 27, "Zazie Beetz es una actriz alemana-estadounidense conocida por sus papeles en 'Atlanta', 'Deadpool 2' y 'Joker'. En 'Joker', interpretó a Sophie Dumond, un personaje central que tiene una conexión crucial con Arthur Fleck/Joker. Beetz ha sido elogiada por su talento y versatilidad.", new DateTime(1991, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/757387BF-FA8B-40DA-8F34-BC9156071FFD.jpg", "Zazie Beetz" },
                    { 28, "Joaquin Phoenix es un actor, productor y activista estadounidense, conocido por sus papeles en películas como 'Gladiator', 'Her' y 'The Master'. Su interpretación del Joker en la película 'Joker' (2019) le valió el Premio Óscar a Mejor Actor, convirtiéndose en uno de los actores más aclamados de su generación.", new DateTime(1974, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/7A3B28F1-2CDD-4F5D-9F57-DCD64C2B63A3.jpg", "Joaquin Phoenix" },
                    { 29, "Lucas Till es un actor estadounidense conocido por sus papeles en 'X-Men: First Class' (2011) como Havok, y por protagonizar la serie de televisión 'MacGyver' (2016-2021) como Angus MacGyver. También ha trabajado en películas como 'Battle: Los Angeles' (2011) y 'The Disappointments Room' (2016).", new DateTime(1990, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/BE15B21C-AE30-4E8D-A4B8-DCD28C027000.jpg", "Lucas Till" },
                    { 30, "Jason Momoa es un actor, productor y director estadounidense conocido por sus papeles en la serie de televisión 'Game of Thrones' como Khal Drogo, y como el superhéroe Aquaman en el universo cinematográfico de DC. También ha trabajado en otras producciones como 'Frontier', 'The Red Road' y 'See'. Su presencia en pantalla y su carisma lo han convertido en uno de los actores más populares de la actualidad.", new DateTime(1979, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://localhost:7290/actores/4DACD85F-6223-4AF4-B146-C8115958ED90.jpg", "Jason Momoa" }
                });

            migrationBuilder.InsertData(
                table: "PeliculasActores",
                columns: new[] { "ActorId", "PeliculaId", "Orden", "Personaje" },
                values: new object[,]
                {
                    { 1, 2, 0, "Rick Dalton" },
                    { 7, 1, 0, "Jack Conrad" },
                    { 7, 2, 0, "Cliff Booth" },
                    { 7, 3, 0, "Roy McBride" },
                    { 7, 4, 0, "Jack Trainer" },
                    { 11, 1, 0, "Nellie LaRoy" },
                    { 11, 2, 0, "Sharon Tate" },
                    { 12, 3, 0, "Helen Lantos" },
                    { 13, 3, 0, "Clifford McBride" },
                    { 14, 4, 0, "Loretta Sage" },
                    { 15, 4, 0, "Dash McMahon" },
                    { 17, 6, 0, "Paul Atreides" },
                    { 18, 6, 0, "Chani" },
                    { 19, 7, 0, "Tonowari" },
                    { 20, 7, 0, "Ronal" },
                    { 21, 8, 0, "Grace" },
                    { 22, 8, 0, "Ethan Hunt" },
                    { 23, 9, 0, "Kamala Khan" },
                    { 24, 9, 0, "Monica Parris" },
                    { 25, 9, 0, "Carol Danvers" },
                    { 26, 10, 0, "Lee Quinzel" },
                    { 27, 10, 0, "Sophie Dumond" },
                    { 28, 10, 0, "Arthur Fleck" },
                    { 29, 5, 0, "Cayden Richards" },
                    { 30, 5, 0, "Connor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 21, 8 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 24, 9 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 26, 10 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 28, 10 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
