using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class ActorDtoExtensions
    {
        public static ActorDto ToDto(this Actor actor)
            => new ActorDto
            {
                Id = actor.Id,
                Nombre = actor.Nombre,
                Biografia = actor.Biografia,
                FechaNacimiento = actor.FechaNacimiento,
                Foto = actor.Foto
            };
    }
}
