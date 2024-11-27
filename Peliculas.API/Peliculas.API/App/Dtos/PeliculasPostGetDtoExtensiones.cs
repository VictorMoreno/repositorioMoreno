using Peliculas.API.Aplicacion.Cines.Dtos;
using Peliculas.API.Aplicacion.Generos.Dtos;

namespace Peliculas.API.App.Dtos
{
    public static class PeliculasPostGetDtoExtensiones
    {
        public static PeliculasPostGetDto ToResponse(List<GeneroDto> generos, List<CineDto> cines)
        {
            return new PeliculasPostGetDto
            {
                Cines = cines,
                Generos = generos
            };
        }
    }
}
