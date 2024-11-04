using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class PeliculaCreacionDtoExtensions
    {
        public static Pelicula ToEntity(this PeliculaCreacionDTO pelicula)
        {
            var registroPelicula = new Pelicula
            {
                Titulo = pelicula.Titulo,
                Resumen = pelicula.Resumen,
                Trailer = pelicula.Trailer,
                EnCines = pelicula.EnCines,
                FechaLanzamiento = pelicula.FechaLanzamiento,
                PeliculasGeneros = pelicula.GenerosIds != null
                ? pelicula.GenerosIds.Select(genero => new PeliculasGeneros() { GeneroId = genero }).ToList()
                : new List<PeliculasGeneros>(),
                PeliculasCines = pelicula.CinesIds != null
                ? pelicula.CinesIds.Select(cine => new PeliculasCines() { CineId = cine }).ToList()
                : new List<PeliculasCines>(),
                PeliculasActores = pelicula.Actores != null
                ? pelicula.Actores.Select(actor => new PeliculasActores() { ActorId = actor.id, Personaje = actor.Personaje }).ToList()
                : new List<PeliculasActores>()
            };

            registroPelicula.EscribirOrdenActores();
            return registroPelicula;
        }

        private static void EscribirOrdenActores(this Pelicula pelicula)
        {
            if (pelicula.PeliculasActores != null)
            {
                for (int i = 0; i < pelicula.PeliculasActores.Count; i++)
                {
                    pelicula.PeliculasActores[i].Orden = i;
                }
            }
        }
    }
}
