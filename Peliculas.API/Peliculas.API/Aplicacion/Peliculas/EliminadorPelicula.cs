using Peliculas.API.Dominio.GestoresImagenes;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class EliminadorPelicula : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _repository;
        private readonly IAlmacenadorArchivoRepositorio _almacenadorArchivo;
        private readonly IProveedorContenedor _proveedorContenedor;

        public EliminadorPelicula(IPeliculaRepositorio repository,
            IAlmacenadorArchivoRepositorio almacenadorArchivo,
            IProveedorContenedor proveedorContenedor)
        {
            this._repository = repository;
            this._almacenadorArchivo = almacenadorArchivo;
            this._proveedorContenedor = proveedorContenedor;
        }

        public async Task Ejecutar(int id)
        {
            Pelicula pelicula = await _repository.ObtenerPorId(id);

            await this._repository.Eliminar(pelicula);

            await this._almacenadorArchivo.BorrarArchivo(pelicula.Poster,
                this._proveedorContenedor.ObtenerContenedorPeliculas());
        }
    }
}