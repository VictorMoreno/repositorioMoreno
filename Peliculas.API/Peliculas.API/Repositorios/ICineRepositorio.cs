using Peliculas.API.DTOs;
using Peliculas.API.Entidades;

namespace Peliculas.API.Repositorios
{
    public interface ICineRepositorio
    {
        Task Guardar(Cine cine);
        Task<List<Cine>> ObtenerCines();
        Task<(int numeroTotal, List<Cine> elementos)> ObtenerCines(PaginacionDto paginacion);
        Task<Cine> ObtenerPorId(int id);
        Task<List<Cine>> ObtenerNoContenidos(List<int> ids);
    }
}
