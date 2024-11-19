using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class BuscadorPeliculas : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _peliculaRepositorio;

        public BuscadorPeliculas(IPeliculaRepositorio peliculaRepositorio)
        {
            this._peliculaRepositorio = peliculaRepositorio;
        }

        public async Task<List<PeliculaDto>> Ejecutar(
            HttpContext context,
            PaginacionDto paginacion,
            string? titulo,
            bool enCines,
            int? generoId,
            bool proximosEstrenos)
        {
            return await this._peliculaRepositorio.Buscar(context, paginacion, titulo, enCines, generoId,
                proximosEstrenos);
        }
    }
}