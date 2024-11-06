using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;

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

        public async Task Ejecutar(int id, PeliculaCreacionDTO input)
        {
            this._repositorio.Actualizar(id,
                input.Titulo,
                input.Resumen,
                input.Trailer,
                input.EnCines,
                input.FechaLanzamiento,
                input.Poster,
                input.GenerosIds,
                input.CinesIds,
                input.Actores.Select(actor => (actor.id, actor.Personaje)).ToList());
        }
    }
}
