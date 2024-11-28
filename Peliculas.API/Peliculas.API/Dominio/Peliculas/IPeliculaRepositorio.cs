using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.Dominio.Peliculas
{
    public interface IPeliculaRepositorio
    {
        Task Actualizar(Pelicula pelicula);
        Task<List<PeliculaDto>> Buscar(HttpContext httpContext,
            PaginacionDto paginacion,
            string? titulo,
            bool enCines,
            int? generoId,
            bool proximosEstrenos);
        Task Eliminar(Pelicula pelicula);
        Task Guardar(Pelicula pelicula);
        Task<List<Pelicula>> ObtenerEnCines();
        Task<Pelicula> ObtenerPorId(int id);
        Task<List<Pelicula>> ObtenerProximosEstrenos();
    }
}
