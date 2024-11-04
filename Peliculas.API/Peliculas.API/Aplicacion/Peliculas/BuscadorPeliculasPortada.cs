using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;

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
            var proximosEstrenos = await this._repository.ObtenerProximosEstrenos();
            var enCines = await this._repository.ObtenerEnCines();

            return LandingPageDtoExtensiones.ToDto(proximosEstrenos, enCines);
        }
    }
}
