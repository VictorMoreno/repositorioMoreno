using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Peliculas.Dtos
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
