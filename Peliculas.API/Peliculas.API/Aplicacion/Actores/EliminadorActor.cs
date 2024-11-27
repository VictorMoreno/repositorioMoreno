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
            await this._repositorio.Eliminar(id);
        }
    }
}
