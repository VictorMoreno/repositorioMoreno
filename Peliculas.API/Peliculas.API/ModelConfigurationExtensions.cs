using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Peliculas.API.Entidades;

namespace Peliculas.API;

public static class ModelConfigurationExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        RellenarGeneros(modelBuilder);
        RellenarActores(modelBuilder);
        RellenarCines(modelBuilder);
        RellenarPeliculas(modelBuilder);
    }

    private static void RellenarPeliculas(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pelicula>().HasData(
            new Pelicula
            {
                Id = 1,
                Titulo = "Babylon",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=hf5faotVKmo",
                FechaLanzamiento = new DateTime(2022, 12, 23),
                Poster = "",
                Resumen =
                    "Una épica historia sobre el exceso, la decadencia y los sueños rotos en el Hollywood de los años 20, donde la transición del cine mudo al sonoro sacude a la industria.",
                // PeliculasGeneros = new List<Genero>
                // {
                //     new Genero { Nombre = "Drama" }, new Genero { Nombre = "Comedia" },
                //     new Genero { Nombre = "Histórica" }
                // },
                // PeliculasCines = new List<Cine>
                //     { new Cine { Nombre = "Cine Capitol", Ubicacion = new Point(40.418974, -3.705269) } },
                // PeliculasActores = new List<Actor>
                // {
                //     new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "Margot Robbie" },
                //     new Actor { Nombre = "Leonardo DiCaprio" }
                // }
            },
            new Pelicula
            {
                Id = 2,
                Titulo = "Once Upon a Time in Hollywood",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=ELeMaP8EPAA",
                FechaLanzamiento = new DateTime(2019, 7, 26),
                Poster = "",
                Resumen =
                    "Un actor de televisión y su doble de riesgo se encuentran con los eventos de 1969 en Hollywood mientras las estrellas de cine se enfrentan a un cambio cultural.",
                // PeliculasGeneros = new List<Genero>
                //     { new Genero { Nombre = "Drama" }, new Genero { Nombre = "Comedia" } },
                // PeliculasCines = new List<Cine>
                //     { new Cine { Nombre = "Cine Ideal", Ubicacion = new Point(40.424975, -3.705754) } },
                // PeliculasActores = new List<Actor>
                // {
                //     new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "Leonardo DiCaprio" },
                //     new Actor { Nombre = "Margot Robbie" }
                // }
            },
            new Pelicula
            {
                Id = 3,
                Titulo = "Ad Astra",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=J5VAs99gJjY",
                FechaLanzamiento = new DateTime(2019, 9, 20),
                Poster = "",
                Resumen =
                    "Un astronauta viaja a los rincones más distantes del sistema solar para encontrar a su padre y resolver un misterio que amenaza la supervivencia de la Tierra.",
                // PeliculasGeneros = new List<Genero>
                //     { new Genero { Nombre = "Ciencia Ficción" }, new Genero { Nombre = "Drama" } },
                // PeliculasCines = new List<Cine>
                //     { new Cine { Nombre = "Cine Coliseum", Ubicacion = new Point(40.418314, -3.707091) } },
                // PeliculasActores = new List<Actor>
                // {
                //     new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "Tommy Lee Jones" },
                //     new Actor { Nombre = "Ruth Negga" }
                // }
            },
            new Pelicula
            {
                Id = 4,
                Titulo = "The Lost City",
                EnCines = true,
                Trailer = "https://www.youtube.com/watch?v=mfjZHsWqL1g",
                FechaLanzamiento = new DateTime(2022, 3, 25),
                Poster = "",
                Resumen =
                    "Una escritora de novelas románticas es secuestrada por un millonario que busca un tesoro perdido en una isla remota, y es rescatada por su modelo de portada.",
                // PeliculasGeneros = new List<Genero>
                // {
                //     new Genero { Nombre = "Aventura" }, new Genero { Nombre = "Comedia" },
                //     new Genero { Nombre = "Acción" }
                // },
                // PeliculasCines = new List<Cine>
                //     { new Cine { Nombre = "Cine ABC", Ubicacion = new Point(40.416775, -3.703790) } },
                // PeliculasActores = new List<Actor>
                // {
                //     new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "Sandra Bullock" },
                //     new Actor { Nombre = "Channing Tatum" }
                // }
            },
            new Pelicula
            {
                Id = 5,
                Titulo = "Wolves",
                EnCines = false,
                Trailer = "https://www.youtube.com/watch?v=example",
                FechaLanzamiento = new DateTime(2025, 6, 15),
                Poster = "",
                Resumen = "Dos solitarios se ven involucrados en el mismo trabajo, que pronto se convierte en una carrera por la supervivencia.",
                // PeliculasGeneros = new List<Genero> { new Genero { Nombre = "Suspenso" }, new Genero { Nombre = "Acción" } },
                // PeliculasCines = new List<Cine> { new Cine { Nombre = "Cine Yelmo", Ubicacion = new Point(40.416775, -3.703790) } },
                // PeliculasActores = new List<Actor> { new Actor { Nombre = "Brad Pitt" }, new Actor { Nombre = "George Clooney" } }
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
            new Genero { Id = 1, Nombre = "Acción" },
            new Genero { Id = 2, Nombre = "Aventura" },
            new Genero { Id = 3, Nombre = "Catástrofe" },
            new Genero { Id = 4, Nombre = "Ciencia Ficción" },
            new Genero { Id = 5, Nombre = "Comedia" },
            new Genero { Id = 6, Nombre = "Documentales" },
            new Genero { Id = 7, Nombre = "Drama" },
            new Genero { Id = 8, Nombre = "Fantasia" },
            new Genero { Id = 9, Nombre = "Terror" },
            new Genero { Id = 10, Nombre = "Romantico" });
    }

    private static void RellenarCines(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cine>().HasData(
            new Cine
            {
                Id = 1,
                Nombre = "Cines Callao",
                Ubicacion = new Point(-3.705912, 40.419829)
            },
            new Cine
            {
                Id = 2,
                Nombre = "Yelmo Cines Ideal",
                Ubicacion = new Point(-3.7065112, 40.41357)
            },
            new Cine
            {
                Id = 3,
                Nombre = "Cinesa Diagonal Mar",
                Ubicacion = new Point(2.2140153, 41.4096507)
            },
            new Cine
            {
                Id = 4,
                Nombre = "Cines Renoir Plaza de España",
                Ubicacion = new Point(-3.7159609, 40.4243981)
            },
            new Cine
            {
                Id = 5,
                Nombre = "Cines Verdi Barcelona",
                Ubicacion = new Point(2.1542843, 41.4039621)
            },
            new Cine
            {
                Id = 6,
                Nombre = "Ocine Granollers",
                Ubicacion = new Point(2.2866108, 41.6067659)
            },
            new Cine
            {
                Id = 7,
                Nombre = "Kinépolis Valencia",
                Ubicacion = new Point(-0.4287164, 39.4778583)
            }
        );
    }
}