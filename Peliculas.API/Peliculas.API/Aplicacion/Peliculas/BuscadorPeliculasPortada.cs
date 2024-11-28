using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class BuscadorPeliculasPortada : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _repository;

        public BuscadorPeliculasPortada(IPeliculaRepositorio repository)
        {
            this._repository = repository;
        }

        public async Task<LandingPageDto> Ejecutar()
        {
            List<Pelicula> proximosEstrenos = await this._repository.ObtenerProximosEstrenos();
            List<Pelicula> enCines = await this._repository.ObtenerEnCines();

            return LandingPageDtoExtensiones.ToDto(proximosEstrenos, enCines);
        }
    }
}