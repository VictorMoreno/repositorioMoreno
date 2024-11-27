using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Dominio.Peliculas;

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