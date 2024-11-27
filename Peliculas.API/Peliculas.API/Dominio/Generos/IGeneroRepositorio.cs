using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.Dominio.Generos
{
    public interface IGeneroRepositorio
    {
        Task<List<Genero>> ObtenerTodosLosGeneros();
        Task<(int numeroTotal, List<Genero> elementos)> ObtenerTodosLosGeneros(PaginacionDto paginacion);
        Task<Genero> ObtenerPorId(int id);
        Task Guardar(Genero genero);
        Task Actualizar(int id, string nombre);
        Task Eliminar(int id);
        Task<List<Genero>> ObtenerNoContenidos(List<int> ids);
    }
}
