using Peliculas.API.Aplicacion.Cines.Dtos;
using Peliculas.API.Aplicacion.Generos.Dtos;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Peliculas.Dtos
{
    public static class PeliculaDtoExtensiones
    {
        public static PeliculaDto ToDto(this Pelicula pelicula,
            (double votoPromedio, int votoUsuario) datosRating = default)
        {
            return new PeliculaDto
            {
                Id = pelicula.Id,
                Titulo = pelicula.Titulo,
                Poster = pelicula.Poster,
                Trailer = pelicula.Trailer,
                Resumen = pelicula.Resumen,
                EnCines = pelicula.EnCines,
                FechaLanzamiento = pelicula.FechaLanzamiento,
                Generos = pelicula.PeliculasGeneros.Select(genero => new GeneroDto
                {
                    Id = genero.GeneroId,
                    Nombre = genero.Genero.Nombre
                }).ToList(),
                Actores = pelicula.PeliculasActores.Select(actor => new PeliculaActorDto
                {
                    Id = actor.ActorId,
                    Nombre = actor.Actor.Nombre,
                    Foto = actor.Actor.Foto,
                    Personaje = actor.Personaje
                }).ToList(),
                Cines = pelicula.PeliculasCines.Select(cine => new CineDto
                {
                    Id = cine.CineId,
                    Latitud = cine.Cine.Ubicacion.Y,
                    Longitud = cine.Cine.Ubicacion.X,
                    Nombre = cine.Cine.Nombre
                }).ToList(),
                VotoUsuario = datosRating.votoUsuario,
                VotoPromedio = datosRating.votoPromedio,
            };
        }
    }
}