using Peliculas.API.Aplicacion.Cines.Dtos;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Compartido.Utilidades;
using Peliculas.API.Dominio.Cines;

namespace Peliculas.API.Aplicacion.Cines
{
    public class BuscadorCinePaginado : IServicioAplicacion
    {
        private readonly ICineRepositorio _repository;

        public BuscadorCinePaginado(ICineRepositorio repository)
        {
            this._repository = repository;
        }

        public async Task<List<CineDto>> Ejecutar(PaginacionDto paginacionDto, HttpContext httpContext)
        {
            (int numeroTotal, List<Cine> elementos) cines = await this._repository.ObtenerCines(paginacionDto);
            await httpContext.InsertarParametrosPaginacionEnCabecera(cines.numeroTotal);
            return cines.elementos.ConvertAll(CineDtoExtensions.ToDto);
        }
    }
}
