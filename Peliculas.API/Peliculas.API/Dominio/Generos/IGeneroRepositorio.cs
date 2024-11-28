using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.Dominio.Generos
{
    public interface IGeneroRepositorio
    {
        Task<List<Genero>> ObtenerGeneros();
        Task<(int numeroTotal, List<Genero> elementos)> ObtenerGeneros(PaginacionDto paginacion);
        Task<Genero> ObtenerPorId(int id);
        Task Guardar(Genero genero);
        Task Actualizar(int id, string nombre);
        Task Eliminar(Genero genero);
        Task<List<Genero>> ObtenerNoContenidos(List<int> ids);
    }
}
