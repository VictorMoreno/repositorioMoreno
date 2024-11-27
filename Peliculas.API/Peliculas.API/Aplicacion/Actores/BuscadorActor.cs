using Peliculas.API.Aplicacion.Actores.Dtos;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Compartido.Utilidades;
using Peliculas.API.Dominio.Actores;

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
