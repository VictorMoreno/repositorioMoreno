using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class LandingPageDtoExtensiones
    {
        public static LandingPageDto ToDto(List<Pelicula> proximosEstrenos, List<Pelicula> enCines)
        {
            return new LandingPageDto
            {
                ProximosEstrenos = proximosEstrenos.ConvertAll(PeliculaDTOExtensiones.ToDto),
                EnCines = enCines.ConvertAll(PeliculaDTOExtensiones.ToDto)
            };
        }
    }
}
