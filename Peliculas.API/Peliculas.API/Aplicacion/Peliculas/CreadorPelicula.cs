using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Dominio.GestoresImagenes;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class CreadorPelicula : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _repositorio;
        private readonly IAlmacenadorArchivoRepositorio _almacenadorArchivo;
        private readonly IProveedorContenedor _proveedorContenedor;

        public CreadorPelicula(IPeliculaRepositorio repositorio, IAlmacenadorArchivoRepositorio almacenadorArchivo,
            IProveedorContenedor proveedorContenedor)
        {
            this._repositorio = repositorio;
            this._almacenadorArchivo = almacenadorArchivo;
            this._proveedorContenedor = proveedorContenedor;
        }

        public async Task Ejecutar(
            string titulo,
            string resumen,
            string trailer,
            bool enCines,
            DateTime fechaLanzamiento,
            IFormFile? poster,
            List<int> generosIds,
            List<int> cinesIds,
            List<ActorPeliculaCreacionDto> actores)
        {
            List<PeliculasActores> actoresAsociados =
                actores.ConvertAll(actor => PeliculasActores.Crear(actor.id, actor.Personaje));

            Pelicula nuevaPelicula = Pelicula.Crear(titulo, resumen, trailer, enCines, fechaLanzamiento,
                poster: string.Empty, actoresAsociados, PeliculasGeneros.Crear(generosIds),
                PeliculasCines.Crear(cinesIds));

            if (poster != null)
            {
                string ficheroPoster = await this._almacenadorArchivo.GuardarArchivo(
                    this._proveedorContenedor.ObtenerContenedorPeliculas(),
                    poster);

                nuevaPelicula.AsignarPoster(ficheroPoster);
            }

            await this._repositorio.Guardar(nuevaPelicula);
        }
    }
}