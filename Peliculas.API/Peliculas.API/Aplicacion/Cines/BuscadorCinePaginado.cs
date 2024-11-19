using Peliculas.API.DTOs;
using Peliculas.API.Entidades;
using Peliculas.API.Repositorios;
using Peliculas.API.Utilidades;

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
