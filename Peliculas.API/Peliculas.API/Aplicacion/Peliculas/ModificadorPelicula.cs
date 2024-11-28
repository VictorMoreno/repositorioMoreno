using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Dominio.GestoresImagenes;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class ModificadorPelicula : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _repositorio;
        private readonly IAlmacenadorArchivoRepositorio _almacenadorArchivo;
        private readonly IProveedorContenedor _proveedorContenedor;

        public ModificadorPelicula(IPeliculaRepositorio repositorio,
            IAlmacenadorArchivoRepositorio almacenadorArchivo,
            IProveedorContenedor proveedorContenedor)
        {
            this._repositorio = repositorio;
            this._almacenadorArchivo = almacenadorArchivo;
            this._proveedorContenedor = proveedorContenedor;
        }

        public async Task Ejecutar(int id, PeliculaCreacionDto input)
        {
            Pelicula pelicula = await this._repositorio.ObtenerPorId(id);

            string rutaPoster = input.Poster != null
                ? await _almacenadorArchivo.EditarArchivo(this._proveedorContenedor.ObtenerContenedorPeliculas(),
                    input.Poster, pelicula.Poster)
                : pelicula.Poster;

            pelicula.Modificar(input.Titulo, input.Resumen, input.Trailer, input.EnCines, input.FechaLanzamiento,
                rutaPoster, input.GenerosIds, input.CinesIds,
                input.Actores.Select(actor => (actor.id, actor.Personaje)).ToList());

            await this._repositorio.Actualizar(pelicula);
        }
    }
}