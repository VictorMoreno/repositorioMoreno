using Peliculas.API.Dominio.Generos;

namespace Peliculas.API.Aplicacion.Generos.Dtos
{
    public static class GeneroDtoExtensions
    {
        public static GeneroDto ToDto(this Genero genero) 
            => new GeneroDto { Id = genero.Id, Nombre = genero.Nombre };
    }
}
