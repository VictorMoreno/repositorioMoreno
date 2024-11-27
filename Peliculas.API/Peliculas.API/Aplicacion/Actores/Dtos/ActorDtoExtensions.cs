using Peliculas.API.Dominio.Actores;

namespace Peliculas.API.Aplicacion.Actores.Dtos
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
