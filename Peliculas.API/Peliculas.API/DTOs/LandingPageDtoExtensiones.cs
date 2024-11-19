using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class LandingPageDtoExtensiones
    {
        public static LandingPageDto ToDto(List<Pelicula> proximosEstrenos, List<Pelicula> enCines)
        {
            return new LandingPageDto
            {
                ProximosEstrenos = proximosEstrenos.ConvertAll(pelicula => PeliculaDtoExtensiones.ToDto(pelicula)),
                EnCines = enCines.ConvertAll(pelicula => PeliculaDtoExtensiones.ToDto(pelicula))
            };
        }
    }
}
