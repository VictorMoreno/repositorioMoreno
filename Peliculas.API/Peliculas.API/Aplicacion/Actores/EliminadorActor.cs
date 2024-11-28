using Peliculas.API.Dominio.Actores;

namespace Peliculas.API.Aplicacion.Actores
{
    public class EliminadorActor : IServicioAplicacion
    {
        private readonly IActorRepositorio _repositorio;

        public EliminadorActor(IActorRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task Ejecutar(int id)
        {
            Actor actor = await this._repositorio.ObtenerPorId(id);

            await this._repositorio.Eliminar(actor);
        }
    }
}