using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class PeliculaActorDtoExtensiones
    {
        public static PeliculaActorDTO ToDto(this Actor actor)
        {
            return new PeliculaActorDTO
            {
                Id = actor.Id,
                Nombre = actor.Nombre,
                Foto = actor.Foto
            };
        }
    }
}
