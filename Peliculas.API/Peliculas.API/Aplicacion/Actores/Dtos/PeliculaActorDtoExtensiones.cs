using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Dominio.Actores;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Actores.Dtos
{
    public static class PeliculaActorDtoExtensiones
    {
        public static PeliculaActorDto ToDto(this PeliculasActores peliculaActor)
        {
            return new PeliculaActorDto
            {
                Id = peliculaActor.Actor.Id,
                Nombre = peliculaActor.Actor.Nombre,
                Foto = peliculaActor.Actor.Foto,
                Personaje = peliculaActor.Personaje,
                Orden = peliculaActor.Orden
            };
        }
        
        public static PeliculaActorDto ToDto(this Actor actor)
        {
            return new PeliculaActorDto
            {
                Id = actor.Id,
                Nombre = actor.Nombre,
                Foto = actor.Foto
            };
        }
    }
}