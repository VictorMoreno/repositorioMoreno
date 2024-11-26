using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Peliculas.API.Entidades;

namespace Peliculas.API;

public static class ModelConfigurationExtensions
{
    private const int IdGeneroAcción = 1;
    private const int IdGeneroAventura = 2;
    private const int IdGeneroCatástrofe = 3;
    private const int IdGeneroCienciaFiccion = 4;
    private const int IdGeneroComedia = 5;
    private const int IdGeneroDocumentales = 6;
    private const int IdGeneroDrama = 7;
    private const int IdGeneroFantasia = 8;
    private const int IdGeneroTerror = 9;
    private const int IdGeneroRomantico = 10;
    private const int IdGeneroHistorica = 11;
    private const int IdGeneroSuspense = 12;
    private const int IdGeneroEspionaje = 13;
    private const int IdGeneroCrimen = 14;
    private const int IdGeneroThriller = 15;

    private const int IdPeliculaBabylon = 1;
    private const int IdPeliculaHollywood = 2;
    private const int IdPeliculaAdAstra = 3;
    private const int IdPeliculaCiudadPerdida = 4;
    private const int IdPeliculaWolves = 5;
    private const int IdPeliculaDune = 6;
    private const int IdPeliculaAvatar = 7;
    private const int IdPeliculaMisionImposible = 8;
    private const int IdPeliculaMarvels = 9;
    private const int IdPeliculaJoker = 10;

    private const int IdCineCallao = 1;
    private const int IdCineYelmoIdeal = 2;
    private const int IdCineDiagonal = 3;
    private const int IdCineRenoir = 4;
    private const int IdCineVerdi = 5;
    private const int IdCineGranollers = 6;
    private const int IdCineKinepolisValencia = 7;

    public static void Seed(this ModelBuilder modelBuilder)
    {
        RellenarGeneros(modelBuilder);
        RellenarActores(modelBuilder);
        RellenarCines(modelBuilder);
        RellenarPeliculas(modelBuilder);
        RellenarPeliculasGeneros(modelBuilder);
        RellenarPeliculasCines(modelBuilder);
    }

    private static void RellenarPeliculasCines(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PeliculasCines>().HasData(
            new PeliculasCines { PeliculaId = IdPeliculaBabylon, CineId = IdCineRenoir },
            new PeliculasCines { PeliculaId = IdPeliculaHollywood, CineId = IdCineCallao },
            new PeliculasCines { PeliculaId = IdPeliculaAdAstra, CineId = IdCineDiagonal },
            new PeliculasCines { PeliculaId = IdPeliculaCiudadPerdida, CineId = IdCineKinepolisValencia },
            new PeliculasCines { PeliculaId = IdPeliculaWolves, CineId = IdCineYelmoIdeal },
            new PeliculasCines { PeliculaId = IdPeliculaDune, CineId = IdCineVerdi },
            new PeliculasCines { PeliculaId = IdPeliculaAvatar, CineId = IdCineCallao },
            new PeliculasCines { PeliculaId = IdPeliculaMisionImposible, CineId = IdCineVerdi },
            new PeliculasCines { PeliculaId = IdPeliculaMarvels, CineId = IdCineDiagonal },
            new PeliculasCines { PeliculaId = IdPeliculaJoker, CineId = IdCineKinepolisValencia }
        );
    }

    private static void RellenarPeliculasGeneros(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PeliculasGeneros>().HasData(
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaBabylon },
            new PeliculasGeneros { GeneroId = IdGeneroComedia, PeliculaId = IdPeliculaBabylon },
            new PeliculasGeneros { GeneroId = IdGeneroHistorica, PeliculaId = IdPeliculaBabylon },
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaHollywood },
            new PeliculasGeneros { GeneroId = IdGeneroComedia, PeliculaId = IdPeliculaHollywood },
            new PeliculasGeneros { GeneroId = IdGeneroCienciaFiccion, PeliculaId = IdPeliculaAdAstra },
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaAdAstra },
            new PeliculasGeneros { GeneroId = IdGeneroAventura, PeliculaId = IdPeliculaCiudadPerdida },
            new PeliculasGeneros { GeneroId = IdGeneroComedia, PeliculaId = IdPeliculaCiudadPerdida },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaCiudadPerdida },
            new PeliculasGeneros { GeneroId = IdGeneroSuspense, PeliculaId = IdPeliculaWolves },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaWolves },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaDune },
            new PeliculasGeneros { GeneroId = IdGeneroAventura, PeliculaId = IdPeliculaDune },
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaDune },
            new PeliculasGeneros { GeneroId = IdGeneroCienciaFiccion, PeliculaId = IdPeliculaAvatar },
            new PeliculasGeneros { GeneroId = IdGeneroFantasia, PeliculaId = IdPeliculaAvatar },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaMisionImposible },
            new PeliculasGeneros { GeneroId = IdGeneroEspionaje, PeliculaId = IdPeliculaMisionImposible },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaMarvels },
            new PeliculasGeneros { GeneroId = IdGeneroAventura, PeliculaId = IdPeliculaMarvels },
            new PeliculasGeneros { GeneroId = IdGeneroCienciaFiccion, PeliculaId = IdPeliculaMarvels },
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaJoker },
            new PeliculasGeneros { GeneroId = IdGeneroCrimen, PeliculaId = IdPeliculaJoker },
            new PeliculasGeneros { GeneroId = IdGeneroThriller, PeliculaId = IdPeliculaJoker }
        );
    }

    private static void RellenarPeliculas(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pelicula>().HasData(
            new Pelicula
            {
                Id = IdPeliculaBabylon,
                Titulo = "Babylon",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=gBil8RpweBE&pp=ygUYYmFieWxvbiB0cmFpbGVyIGVzcGHDsW9s",
                FechaLanzamiento = new DateTime(2022, 12, 23),
                Poster = "https://localhost:7290/peliculas/ea9fd07a-1fb5-4eb7-a01a-1c27266c2309.png",
                Resumen =
                    "Una épica historia sobre el exceso, la decadencia y los sueños rotos en el Hollywood de los años 20, donde la transición del cine mudo al sonoro sacude a la industria.",
                // PeliculasActores = new List<Actor>
                // {
                //     new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "Margot Robbie" },
                //     new Actor { Nombre = "Leonardo DiCaprio" }
                // }
            },
            new Pelicula
            {
                Id = IdPeliculaHollywood,
                Titulo = "Érase una vez en… Hollywood",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=J0rFGJV3cYw",
                FechaLanzamiento = new DateTime(2019, 7, 26),
                Poster = "https://localhost:7290/peliculas/14a89f1e-d997-46ec-ae77-37b43118b00c.jpg",
                Resumen =
                    "Un actor de televisión y su doble de riesgo se encuentran con los eventos de 1969 en Hollywood mientras las estrellas de cine se enfrentan a un cambio cultural.",
                // PeliculasActores = new List<Actor>
                // {
                //     new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "Leonardo DiCaprio" },
                //     new Actor { Nombre = "Margot Robbie" }
                // }
            },
            new Pelicula
            {
                Id = IdPeliculaAdAstra,
                Titulo = "Ad Astra",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=2hy4clp3IMM",
                FechaLanzamiento = new DateTime(2019, 9, 20),
                Poster = "https://localhost:7290/peliculas/eecfa05e-7968-474a-93c4-3f5b24e5cb66.jpg",
                Resumen =
                    "Un astronauta viaja a los rincones más distantes del sistema solar para encontrar a su padre y resolver un misterio que amenaza la supervivencia de la Tierra.",
                // PeliculasActores = new List<Actor>
                // {
                //     new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "Tommy Lee Jones" },
                //     new Actor { Nombre = "Ruth Negga" }
                // }
            },
            new Pelicula
            {
                Id = IdPeliculaCiudadPerdida,
                Titulo = "La ciudad perdida",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=DWq5cjkxEQQ",
                FechaLanzamiento = new DateTime(2022, 3, 25),
                Poster = "https://localhost:7290/peliculas/0acee9d1-94df-4229-aab0-bf7c308e2933.jpg",
                Resumen =
                    "Una escritora de novelas románticas es secuestrada por un millonario que busca un tesoro perdido en una isla remota, y es rescatada por su modelo de portada.",
                // PeliculasActores = new List<Actor>
                // {
                //     new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "Sandra Bullock" },
                //     new Actor { Nombre = "Channing Tatum" }
                // }
            },
            new Pelicula
            {
                Id = IdPeliculaWolves,
                Titulo = "Wolves",
                EnCines = false,
                Trailer = "https://www.youtube.com/watch?v=Ti_7suoHmRQ",
                FechaLanzamiento = new DateTime(2025, 6, 15),
                Poster = "",
                Resumen =
                    "Dos solitarios se ven involucrados en el mismo trabajo, que pronto se convierte en una carrera por la supervivencia.",
                // PeliculasActores = new List<Actor> { new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "George Clooney" } }
            },
            new Pelicula
            {
                Id = IdPeliculaDune,
                Titulo = "Dune: Parte dos",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=6OmJF6VjKMA",
                FechaLanzamiento = new DateTime(2024, 3, 15),
                Poster = "https://localhost:7290/peliculas/98e8356c-3214-454f-b6c5-81f82de778ff.jpg",
                Resumen =
                    "La segunda parte de la épica adaptación de Dune, donde Paul Atreides busca venganza y un legado que cambiará el universo.",
            },
            new Pelicula
            {
                Id = IdPeliculaAvatar,
                Titulo = "Avatar 3",
                EnCines = false,
                Trailer = "https://www.youtube.com/watch?v=YXtWPVFk5TQ",
                FechaLanzamiento = new DateTime(2025, 12, 19),
                Poster = "https://localhost:7290/peliculas/aad70b69-1dd1-4b5a-8e4a-1941c00fe96f.jpg",
                Resumen =
                    "La siguiente entrega de la saga de ciencia ficción de Pandora, explorando nuevas regiones del planeta y enfrentándose a amenazas desconocidas.",
            },
            new Pelicula
            {
                Id = IdPeliculaMisionImposible,
                Titulo = "Misión: Imposible - Sentencia Mortal Parte Dos",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=8jRMVhGwy0M",
                FechaLanzamiento = new DateTime(2024, 6, 28),
                Poster = "https://localhost:7290/peliculas/ec9ebb58-73f3-4a0e-ae57-2e7de11da751.jpg",
                Resumen =
                    "Ethan Hunt continúa su lucha contra una nueva amenaza global en la segunda parte de esta entrega de alta tensión y acción.",
            },
            new Pelicula
            {
                Id = IdPeliculaMarvels,
                Titulo = "The Marvels",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=gdSGIf8kbhg",
                FechaLanzamiento = new DateTime(2024, 11, 8),
                Poster = "https://localhost:7290/peliculas/c2eb8dbc-9a1f-4bbe-a8d5-346999a51022.jpg",
                Resumen =
                    "Las heroínas del universo Marvel, Carol Danvers, Kamala Khan y Monica Rambeau, unen fuerzas para enfrentar una amenaza cósmica.",
            },
            new Pelicula
            {
                Id = IdPeliculaJoker,
                Titulo = "Joker: locura de a dos",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=7SZfThvjt5I",
                FechaLanzamiento = new DateTime(2024, 10, 4),
                Poster = "https://localhost:7290/peliculas/c900cffe-1828-46f1-9893-99b86ec064ab.png",
                Resumen =
                    "Arthur Fleck regresa como el Joker en una secuela que explora su relación con Harley Quinn y el oscuro descenso de ambos."
            }
        );
    }

    private static void RellenarActores(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>().HasData(
            new Actor
            {
                Id = 1,
                Nombre = "Leonardo DiCaprio",
                FechaNacimiento = new DateTime(1974, 11, 11),
                Foto = "https://localhost:7290/actores/39c562aa-c83d-4bc7-97aa-8895dc46880c.jpg",
                Biografia =
                    "Leonardo DiCaprio es un actor y productor estadounidense conocido por películas como 'Titanic', 'Inception' y 'The Revenant'. Ganó un Óscar por 'The Revenant'."
            },
            new Actor
            {
                Id = 2,
                Nombre = "Meryl Streep",
                FechaNacimiento = new DateTime(1949, 6, 22),
                Foto = "https://localhost:7290/actores/ade14658-7f47-496a-ace0-7c1d0414f468.jpg",
                Biografia =
                    "Meryl Streep es una reconocida actriz estadounidense, famosa por su habilidad para interpretar distintos personajes. Ha ganado tres premios Óscar y es una de las actrices más nominadas en la historia del cine."
            },
            new Actor
            {
                Id = 3,
                Nombre = "Robert De Niro",
                FechaNacimiento = new DateTime(1943, 8, 17),
                Foto = "https://localhost:7290/actores/b0ff03ae-86fa-426b-9ce2-9e4975678026.jpg",
                Biografia =
                    "Robert De Niro es un actor y productor estadounidense, famoso por sus papeles en 'Taxi Driver', 'Raging Bull' y 'Goodfellas'. Ha ganado dos premios Óscar."
            },
            new Actor
            {
                Id = 4,
                Nombre = "Scarlett Johansson",
                FechaNacimiento = new DateTime(1984, 11, 22),
                Foto = "https://localhost:7290/actores/ef905ad6-7cb3-46d9-adfc-e2961efd0437.jpg",
                Biografia =
                    "Scarlett Johansson es una actriz estadounidense conocida por su papel en el Universo Cinematográfico de Marvel como 'Black Widow' y en películas como 'Lost in Translation'."
            },
            new Actor
            {
                Id = 5,
                Nombre = "Tom Hanks",
                FechaNacimiento = new DateTime(1956, 7, 9),
                Foto = "https://localhost:7290/actores/91510ed1-a7dd-4592-bbc4-e3baa12285c0.jpg",
                Biografia =
                    "Tom Hanks es un actor y productor estadounidense conocido por sus papeles en 'Forrest Gump', 'Saving Private Ryan' y 'Cast Away'. Ha ganado dos premios Óscar consecutivos."
            },
            new Actor
            {
                Id = 6,
                Nombre = "Natalie Portman",
                FechaNacimiento = new DateTime(1981, 6, 9),
                Foto = "https://localhost:7290/actores/3531dfef-80bd-4e62-b40b-d7f5e89ddb27.jpg",
                Biografia =
                    "Natalie Portman es una actriz y productora estadounidense-israelí, conocida por su papel en 'Black Swan', por el que ganó un Óscar, y su participación en la saga 'Star Wars'."
            },
            new Actor
            {
                Id = 7,
                Nombre = "Brad Pitt",
                FechaNacimiento = new DateTime(1963, 12, 18),
                Foto = "https://localhost:7290/actores/fed532b0-86d5-4e3d-9978-cbaf00f53bd2.jpg",
                Biografia =
                    "Brad Pitt es un actor y productor estadounidense famoso por sus papeles en 'Fight Club', 'Inglourious Basterds' y 'Once Upon a Time in Hollywood', por el que ganó un Óscar."
            },
            new Actor
            {
                Id = 8,
                Nombre = "Emma Stone",
                FechaNacimiento = new DateTime(1988, 11, 6),
                Foto = "https://localhost:7290/actores/626b3111-fd53-40f9-a88c-02dcc38587a2.jpg",
                Biografia =
                    "Emma Stone es una actriz estadounidense conocida por su papel en 'La La Land', por el cual ganó un Óscar. También es conocida por su trabajo en 'Easy A' y 'The Amazing Spider-Man'."
            },
            new Actor
            {
                Id = 9,
                Nombre = "Morgan Freeman",
                FechaNacimiento = new DateTime(1937, 6, 1),
                Foto = "https://localhost:7290/actores/76ac4765-8bcd-4075-8bf2-25c601e0a891.jpeg",
                Biografia =
                    "Morgan Freeman es un actor y narrador estadounidense conocido por su voz distintiva y papeles en 'The Shawshank Redemption', 'Se7en' y 'Driving Miss Daisy'. Ganó un Óscar en 2005."
            },
            new Actor
            {
                Id = 10,
                Nombre = "Charlize Theron",
                FechaNacimiento = new DateTime(1975, 8, 7),
                Foto = "https://localhost:7290/actores/620ba7f7-38ac-4727-9a7c-8f3f7dcfb47e.jpg",
                Biografia =
                    "Charlize Theron es una actriz y productora sudafricana conocida por su papel en 'Monster', por el que ganó un Óscar, y su actuación en películas de acción como 'Mad Max: Fury Road'."
            }
        );
    }

    private static void RellenarGeneros(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genero>().HasData(
            new Genero { Id = IdGeneroAcción, Nombre = "Acción" },
            new Genero { Id = IdGeneroAventura, Nombre = "Aventura" },
            new Genero { Id = IdGeneroCatástrofe, Nombre = "Catástrofe" },
            new Genero { Id = IdGeneroCienciaFiccion, Nombre = "Ciencia Ficción" },
            new Genero { Id = IdGeneroComedia, Nombre = "Comedia" },
            new Genero { Id = IdGeneroDocumentales, Nombre = "Documentales" },
            new Genero { Id = IdGeneroDrama, Nombre = "Drama" },
            new Genero { Id = IdGeneroFantasia, Nombre = "Fantasia" },
            new Genero { Id = IdGeneroTerror, Nombre = "Terror" },
            new Genero { Id = IdGeneroRomantico, Nombre = "Romantico" },
            new Genero { Id = IdGeneroHistorica, Nombre = "Historica" },
            new Genero { Id = IdGeneroSuspense, Nombre = "Suspense" },
            new Genero { Id = IdGeneroEspionaje, Nombre = "Espionaje" },
            new Genero { Id = IdGeneroCrimen, Nombre = "Crimen" },
            new Genero { Id = IdGeneroThriller, Nombre = "Thriller" });
    }

    private static void RellenarCines(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cine>().HasData(
            new Cine
            {
                Id = IdCineCallao,
                Nombre = "Cines Callao",
                Ubicacion = new Point(-3.705912, 40.419829)
            },
            new Cine
            {
                Id = IdCineYelmoIdeal,
                Nombre = "Yelmo Cines Ideal",
                Ubicacion = new Point(-3.7065112, 40.41357)
            },
            new Cine
            {
                Id = IdCineDiagonal,
                Nombre = "Cinesa Diagonal Mar",
                Ubicacion = new Point(2.2140153, 41.4096507)
            },
            new Cine
            {
                Id = IdCineRenoir,
                Nombre = "Cines Renoir Plaza de España",
                Ubicacion = new Point(-3.7159609, 40.4243981)
            },
            new Cine
            {
                Id = IdCineVerdi,
                Nombre = "Cines Verdi Barcelona",
                Ubicacion = new Point(2.1542843, 41.4039621)
            },
            new Cine
            {
                Id = IdCineGranollers,
                Nombre = "Ocine Granollers",
                Ubicacion = new Point(2.2866108, 41.6067659)
            },
            new Cine
            {
                Id = IdCineKinepolisValencia,
                Nombre = "Kinépolis Valencia",
                Ubicacion = new Point(-0.4287164, 39.4778583)
            }
        );
    }
}