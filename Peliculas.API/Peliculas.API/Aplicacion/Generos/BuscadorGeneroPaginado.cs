using Peliculas.API.DTOs;
using Peliculas.API.Entidades;
using Peliculas.API.Repositorios;
using Peliculas.API.Utilidades;

namespace Peliculas.API.Aplicacion.Generos
{
    public class BuscadorGeneroPaginado : IServicioAplicacion
    {
        private readonly IGeneroRepositorio _repositorio;

        public BuscadorGeneroPaginado(IGeneroRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task<List<GeneroDto>> Ejecutar(PaginacionDto paginacionDto, HttpContext httpContext)
        {
            (int numeroTotal, List<Genero> elementos) generos = await this._repositorio.ObtenerTodosLosGeneros(paginacionDto);
            await httpContext.InsertarParametrosPaginacionEnCabecera(generos.numeroTotal);
            return generos.elementos.ConvertAll(GeneroDtoExtensions.ToDto);
        }
    }
}
