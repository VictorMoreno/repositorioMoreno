using Peliculas.API.DTOs;
using Peliculas.API.Entidades;
using Peliculas.API.Repositorios;
using Peliculas.API.Utilidades;

namespace Peliculas.API.Aplicacion.Actores
{
    public class BuscadorActor : IServicioAplicacion
    {
        private readonly IActorRepositorio _repositorio;

        public BuscadorActor(IActorRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task<List<ActorDto>> Ejecutar(PaginacionDto paginacionDto, HttpContext httpContext)
        {
            (int numeroTotal, List<Actor> elementos) actores = await this._repositorio.ObtenerActores(paginacionDto);
            await httpContext.InsertarParametrosPaginacionEnCabecera(actores.numeroTotal);
            return actores.elementos.ConvertAll(ActorDtoExtensions.ToDto);
        }
    }
}
