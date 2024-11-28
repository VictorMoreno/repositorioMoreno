using Peliculas.API.Dominio.Actores;
using Peliculas.API.Dominio.GestoresImagenes;

namespace Peliculas.API.Aplicacion.Actores
{
    public class CreadorActor : IServicioAplicacion
    {
        private readonly IActorRepositorio _repositorio;
        private readonly IAlmacenadorArchivoRepositorio _almacenadorArchivo;
        private readonly IProveedorContenedor _proveedorContenedor;

        public CreadorActor(IActorRepositorio repositorio, IAlmacenadorArchivoRepositorio almacenadorArchivo,
            IProveedorContenedor proveedorContenedor)
        {
            this._repositorio = repositorio;
            this._almacenadorArchivo = almacenadorArchivo;
            this._proveedorContenedor = proveedorContenedor;
        }

        public async Task Ejecutar(string nombre, string? biografia, DateTime fechaNacimiento, IFormFile? foto)
        {
            Actor actor = Actor.Crear(nombre,
                string.IsNullOrEmpty(biografia) ? string.Empty : biografia,
                fechaNacimiento);

            if (foto != null)
            {
                actor.Foto = await this._almacenadorArchivo.GuardarArchivo(
                    this._proveedorContenedor.ObtenerContenedorActores(),
                    foto);
            }

            await this._repositorio.Guardar(actor);
        }
    }
}