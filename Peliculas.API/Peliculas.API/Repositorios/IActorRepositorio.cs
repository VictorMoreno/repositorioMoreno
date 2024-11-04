using Peliculas.API.DTOs;
using Peliculas.API.Entidades;

namespace Peliculas.API.Repositorios
{
    public interface IActorRepositorio
    {
        Task Actualizar(int id, string nombre,
            string biografia,
            DateTime fechaNacimiento,
            string foto);
        Task Eliminar(int id);
        Task Guardar(Actor actor);
        Task<Actor> ObtenerPorId(int id);
        Task<(int numeroTotal, List<Actor> elementos)> ObtenerActores(PaginacionDto paginacion);
        Task<List<Actor>> BuscarPorNombre(string nombre);
    }
}
