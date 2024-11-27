using Peliculas.API.Aplicacion.Cines.Dtos;
using Peliculas.API.Dominio.Cines;

namespace Peliculas.API.Aplicacion.Cines
{
    public class BuscadorCine : IServicioAplicacion
    {
        private readonly ICineRepositorio _repository;

        public BuscadorCine(ICineRepositorio repository)
        {
            this._repository = repository;
        }

        public async Task<List<CineDto>> Ejecutar()
        {
            var cines = await this._repository.ObtenerCines();
            return cines.ConvertAll(CineDtoExtensions.ToDto);
        }
    }
}
