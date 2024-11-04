using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class GeneroDtoExtensions
    {
        public static GeneroDto ToDto(this Genero genero) 
            => new GeneroDto { Id = genero.Id, Nombre = genero.Nombre };
    }
}
