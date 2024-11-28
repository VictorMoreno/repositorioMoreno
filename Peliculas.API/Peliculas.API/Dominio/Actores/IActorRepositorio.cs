using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.Dominio.Actores
{
    public interface IActorRepositorio
    {
        Task Actualizar(Actor actor);
        Task Eliminar(Actor actor);
        Task Guardar(Actor actor);
        Task<Actor> ObtenerPorId(int id);
        Task<(int numeroTotal, List<Actor> elementos)> ObtenerActores(PaginacionDto paginacion);
        Task<List<Actor>> BuscarPorNombre(string nombre);
    }
}
