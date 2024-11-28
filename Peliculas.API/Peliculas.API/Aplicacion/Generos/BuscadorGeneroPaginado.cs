using Peliculas.API.Aplicacion.Generos.Dtos;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Compartido.Utilidades;
using Peliculas.API.Dominio.Generos;

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
            (int numeroTotal, List<Genero> elementos) generos = await this._repositorio.ObtenerGeneros(paginacionDto);
            await httpContext.InsertarParametrosPaginacionEnCabecera(generos.numeroTotal);
            return generos.elementos.ConvertAll(GeneroDtoExtensions.ToDto);
        }
    }
}
