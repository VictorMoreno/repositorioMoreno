using Peliculas.API.Aplicacion.Actores.Dtos;
using Peliculas.API.Aplicacion.Cines.Dtos;
using Peliculas.API.Aplicacion.Generos.Dtos;
using Peliculas.API.Dominio.Cines;
using Peliculas.API.Dominio.Generos;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Peliculas.Dtos
{
    public static class PeliculasPutGetDtoExtensiones
    {
        public static PeliculasPutGetDto ToDto(List<Genero> generosNoSeleccionados,
            List<Cine> cinesNoSeleccionados,
            Pelicula pelicula,
            List<PeliculasGeneros> generosSeleccionados,
            List<PeliculasCines> cinesSeleccionados,
            List<PeliculasActores> actores)
        {
            return new PeliculasPutGetDto
            {
                CinesNoSeleccionados = cinesNoSeleccionados.ConvertAll(CineDtoExtensions.ToDto),
                CinesSeleccionados = cinesSeleccionados.Select(cs => cs.Cine.ToDto()).ToList(),
                GenerosNoSeleccionados = generosNoSeleccionados.ConvertAll(GeneroDtoExtensions.ToDto),
                GenerosSeleccionados = generosSeleccionados.Select(gs => gs.Genero.ToDto()).ToList(),
                Pelicula = pelicula.ToDto(),
                Actores = actores.Select(peliculaActor => PeliculaActorDtoExtensiones.ToDto(peliculaActor)).ToList()
            };
        }
    }
}
