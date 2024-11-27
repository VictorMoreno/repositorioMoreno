using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Dominio.Cines;
using Peliculas.API.Dominio.Generos;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class BuscadorPeliculaParaEdicion : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _peliculaRepository;
        private readonly IGeneroRepositorio _generoRepositorio;
        private readonly ICineRepositorio _cineRepositorio;

        public BuscadorPeliculaParaEdicion(IPeliculaRepositorio peliculaRepository,
            IGeneroRepositorio generoRepositorio,
            ICineRepositorio cineRepositorio)
        {
            this._peliculaRepository = peliculaRepository;
            this._generoRepositorio = generoRepositorio;
            this._cineRepositorio = cineRepositorio;
        }

        public async Task<PeliculasPutGetDto> Ejecutar(int id)
        {
            Pelicula pelicula = await this._peliculaRepository.ObtenerPorId(id);

            List<int> idsGenerosSeleccionados = pelicula.PeliculasGeneros.Select(genero => genero.GeneroId).ToList();
            List<Genero> generosNoSeleccionados =
                await this._generoRepositorio.ObtenerNoContenidos(idsGenerosSeleccionados);

            List<int> idsCinesSeleccionados = pelicula.PeliculasCines.Select(genero => genero.CineId).ToList();
            List<Cine> cinesNoSeleccionados = await this._cineRepositorio.ObtenerNoContenidos(idsCinesSeleccionados);

            return PeliculasPutGetDtoExtensiones.ToDto(generosNoSeleccionados, cinesNoSeleccionados, pelicula,
                pelicula.PeliculasGeneros, pelicula.PeliculasCines, pelicula.PeliculasActores);
        }
    }
}