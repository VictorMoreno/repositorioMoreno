using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class GeneroCreacionDtoExtensions
    {
        public static Genero ToEntity(this GeneroCreacionDto generoDto)
        {
            return new Genero
            {
                Nombre = generoDto.Nombre
            };
        }
    }
}
