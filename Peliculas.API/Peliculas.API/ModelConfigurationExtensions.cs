using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Peliculas.API.Entidades;

namespace Peliculas.API;

public static class ModelConfigurationExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        RellenarGeneros(modelBuilder);
        // RellenarCines(modelBuilder);
        RellenarActores(modelBuilder);
    }

    private static void RellenarActores(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>().HasData(
            new Actor
            {
                Id = 1,
                Nombre = "Leonardo DiCaprio",
                FechaNacimiento = new DateTime(1974, 11, 11),
                Foto = "..\\..\\Imagenes\\actores\\LeonardoDiCaprio.jpg",
                Biografia =
                    "Leonardo DiCaprio es un actor y productor estadounidense conocido por películas como 'Titanic', 'Inception' y 'The Revenant'. Ganó un Óscar por 'The Revenant'."
            },
            new Actor
            {
                Id = 2,
                Nombre = "Meryl Streep",
                FechaNacimiento = new DateTime(1949, 6, 22),
                Foto = "..\\..\\Imagenes\\actores\\MerylStreep.jpg",
                Biografia =
                    "Meryl Streep es una reconocida actriz estadounidense, famosa por su habilidad para interpretar distintos personajes. Ha ganado tres premios Óscar y es una de las actrices más nominadas en la historia del cine."
            },
            new Actor
            {
                Id = 3,
                Nombre = "Robert De Niro",
                FechaNacimiento = new DateTime(1943, 8, 17),
                Foto = "..\\..\\Imagenes\\actores\\RobertDeNiro.jpg",
                Biografia =
                    "Robert De Niro es un actor y productor estadounidense, famoso por sus papeles en 'Taxi Driver', 'Raging Bull' y 'Goodfellas'. Ha ganado dos premios Óscar."
            },
            new Actor
            {
                Id = 4,
                Nombre = "Scarlett Johansson",
                FechaNacimiento = new DateTime(1984, 11, 22),
                Foto = "..\\..\\Imagenes\\actores\\ScarlettJohansson.jpg",
                Biografia =
                    "Scarlett Johansson es una actriz estadounidense conocida por su papel en el Universo Cinematográfico de Marvel como 'Black Widow' y en películas como 'Lost in Translation'."
            },
            new Actor
            {
                Id = 5,
                Nombre = "Tom Hanks",
                FechaNacimiento = new DateTime(1956, 7, 9),
                Foto = "..\\..\\Imagenes\\actores\\TomHanks.jpg",
                Biografia =
                    "Tom Hanks es un actor y productor estadounidense conocido por sus papeles en 'Forrest Gump', 'Saving Private Ryan' y 'Cast Away'. Ha ganado dos premios Óscar consecutivos."
            },
            new Actor
            {
                Id = 6,
                Nombre = "Natalie Portman",
                FechaNacimiento = new DateTime(1981, 6, 9),
                Foto = "..\\..\\Imagenes\\actores\\NataliePortman.jpg",
                Biografia =
                    "Natalie Portman es una actriz y productora estadounidense-israelí, conocida por su papel en 'Black Swan', por el que ganó un Óscar, y su participación en la saga 'Star Wars'."
            },
            new Actor
            {
                Id = 7,
                Nombre = "Brad Pitt",
                FechaNacimiento = new DateTime(1963, 12, 18),
                Foto = "..\\..\\Imagenes\\actores\\EmmaStone.jpg",
                Biografia =
                    "Brad Pitt es un actor y productor estadounidense famoso por sus papeles en 'Fight Club', 'Inglourious Basterds' y 'Once Upon a Time in Hollywood', por el que ganó un Óscar."
            },
            new Actor
            {
                Id = 8,
                Nombre = "Emma Stone",
                FechaNacimiento = new DateTime(1988, 11, 6),
                Foto =
                    "..\\..\\Imagenes\\actores\\.jpg",
                Biografia =
                    "Emma Stone es una actriz estadounidense conocida por su papel en 'La La Land', por el cual ganó un Óscar. También es conocida por su trabajo en 'Easy A' y 'The Amazing Spider-Man'."
            },
            new Actor
            {
                Id = 9,
                Nombre = "Morgan Freeman",
                FechaNacimiento = new DateTime(1937, 6, 1),
                Foto = "..\\..\\Imagenes\\actores\\MorganFreeman.jpg",
                Biografia =
                    "Morgan Freeman es un actor y narrador estadounidense conocido por su voz distintiva y papeles en 'The Shawshank Redemption', 'Se7en' y 'Driving Miss Daisy'. Ganó un Óscar en 2005."
            },
            new Actor
            {
                Id = 10,
                Nombre = "Charlize Theron",
                FechaNacimiento = new DateTime(1975, 8, 7),
                Foto = "..\\..\\Imagenes\\actores\\CharlizeTheron.jpg",
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
            });
    }
}