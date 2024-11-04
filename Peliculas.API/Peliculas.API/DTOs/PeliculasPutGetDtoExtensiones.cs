using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
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
                CinesNoSeleccionados = cinesNoSeleccionados.ConvertAll(CineDTOExtensions.ToDto),
                CinesSeleccionados = cinesSeleccionados.Select(cs => cs.Cine.ToDto()).ToList(),
                GenerosNoSeleccionados = generosNoSeleccionados.ConvertAll(GeneroDtoExtensions.ToDto),
                GenerosSeleccionados = generosSeleccionados.Select(gs => gs.Genero.ToDto()).ToList(),
                Pelicula = pelicula.ToDto(),
                Actores = actores.Select(peliculaActor => PeliculaActorDtoExtensiones.ToDto(peliculaActor.Actor)).ToList()
            };
        }
    }
}
