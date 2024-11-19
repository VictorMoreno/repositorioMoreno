using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;

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

        public async Task Ejecutar(PeliculaCreacionDto input)
        {
            var entidad = input.ToEntity();

            if (input.Poster != null)
            {
                entidad.Poster =
                    await this._almacenadorArchivo.GuardarArchivo(
                        this._proveedorContenedor.ObtenerContenedorPeliculas(), input.Poster);
            }

            await this._repositorio.Guardar(entidad);
        }
    }
}