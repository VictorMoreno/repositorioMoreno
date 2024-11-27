using Peliculas.API.Aplicacion.Actores.Dtos;
using Peliculas.API.Dominio.Actores;

namespace Peliculas.API.Aplicacion.Actores
{
    public class EncontradorActor : IServicioAplicacion
    {
        private readonly IActorRepositorio _repositorio;

        public EncontradorActor(IActorRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task<ActorDto> Ejecutar(int id)
        {
            Actor actor = await this._repositorio.ObtenerPorId(id);

            if (actor == null)
            {
                throw new FileNotFoundException();
            }

            return ActorDtoExtensions.ToDto(actor);
        }
    }
}
