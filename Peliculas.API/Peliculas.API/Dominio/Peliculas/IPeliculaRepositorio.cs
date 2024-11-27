using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.Dominio.Peliculas
{
    public interface IPeliculaRepositorio
    {
        Task Actualizar(int id,
            string titulo, 
            string resumen, 
            string trailer, 
            bool enCines, 
            DateTime fechaLanzamiento, 
            IFormFile poster, 
            List<int> idsGeneros,
            List<int> idsCines,
            List<(int id, string personaje)> idsActores);
        Task<List<PeliculaDto>> Buscar(HttpContext httpContext,
            PaginacionDto paginacion,
            string? titulo,
            bool enCines,
            int? generoId,
            bool proximosEstrenos);
        Task Eliminar(int id);
        Task Guardar(Pelicula pelicula);
        Task<List<Pelicula>> ObtenerEnCines();
        Task<Pelicula> ObtenerPorId(int id);
        Task<List<Pelicula>> ObtenerProximosEstrenos();
    }
}
