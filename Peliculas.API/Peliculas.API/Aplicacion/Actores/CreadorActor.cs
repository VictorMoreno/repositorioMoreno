using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;

namespace Peliculas.API.Aplicacion.Actores
{
    public class CreadorActor : IServicioAplicacion
    {
        private readonly IActorRepositorio _repositorio;
        private readonly IAlmacenadorArchivoRepositorio _almacenadorArchivo;
        private readonly IProveedorContenedor _proveedorContenedor;

        public CreadorActor(IActorRepositorio repositorio, IAlmacenadorArchivoRepositorio almacenadorArchivo, IProveedorContenedor proveedorContenedor)
        {
            this._repositorio = repositorio;
            this._almacenadorArchivo = almacenadorArchivo;
            this._proveedorContenedor = proveedorContenedor;
        }

        public async Task Ejecutar(ActorCreacionDto actorCreacionDto)
        {
            var entidadActor = actorCreacionDto.ToEntity();

            if (actorCreacionDto.Foto != null)
            {
                entidadActor.Foto = await this._almacenadorArchivo.GuardarArchivo(this._proveedorContenedor.ObtenerContenedorActores(), actorCreacionDto.Foto);
            }

            await this._repositorio.Guardar(entidadActor);
        }
    }
}
