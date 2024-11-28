using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.Dominio.Cines
{
    public interface ICineRepositorio
    {
        Task Guardar(Cine cine);
        Task<List<Cine>> ObtenerCines();
        Task<(int numeroTotal, List<Cine> elementos)> ObtenerCines(PaginacionDto paginacion);
        Task<Cine> ObtenerPorId(int id);
        Task<List<Cine>> ObtenerNoContenidos(List<int> ids);
        Task Eliminar(int id);
        Task Actualizar(Cine cine);
    }
}
