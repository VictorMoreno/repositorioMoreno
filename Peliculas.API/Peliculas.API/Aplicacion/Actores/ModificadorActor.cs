using Peliculas.API.Aplicacion.Actores.Dtos;
using Peliculas.API.Dominio.Actores;
using Peliculas.API.Dominio.GestoresImagenes;

namespace Peliculas.API.Aplicacion.Actores
{
    public class ModificadorActor : IServicioAplicacion
    {
        private readonly IActorRepositorio _repositorio;
        private readonly IAlmacenadorArchivoRepositorio _almacenadorArchivo;
        private readonly IProveedorContenedor _proveedorContenedor;

        public ModificadorActor(IActorRepositorio repositorio,
            IAlmacenadorArchivoRepositorio almacenadorArchivo,
            IProveedorContenedor proveedorContenedor)
        {
            this._repositorio = repositorio;
            this._almacenadorArchivo = almacenadorArchivo;
            this._proveedorContenedor = proveedorContenedor;
        }

        public async Task Ejecutar(int id, ActorCreacionDto input)
        {
            Actor actor = await this._repositorio.ObtenerPorId(id);

            string urlFoto = string.Empty;

            if (input.Foto != null)
            {
                urlFoto = await _almacenadorArchivo.EditarArchivo(this._proveedorContenedor.ObtenerContenedorActores(),
                    input.Foto, actor.Foto);
            }

            actor.Modificar(input.Nombre, input.Biografia, input.FechaNacimiento, urlFoto);

            await this._repositorio.Actualizar(actor);
        }
    }
}