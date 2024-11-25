using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class ActorCreacionDtoExtensions
    {
        public static Actor ToEntity(this ActorCreacionDto actorCreacion)
        {
            return new Actor
            {
                Nombre = actorCreacion.Nombre,
                Biografia = string.IsNullOrEmpty(actorCreacion.Biografia) ? string.Empty : actorCreacion.Biografia,
                FechaNacimiento = actorCreacion.FechaNacimiento,
                Foto = string.Empty
            };
        }
    }
}