using Peliculas.API.Dominio.Generos;

namespace Peliculas.API.Aplicacion.Generos.Dtos
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
