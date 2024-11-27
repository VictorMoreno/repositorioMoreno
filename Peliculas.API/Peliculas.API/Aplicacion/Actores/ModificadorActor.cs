using Microsoft.EntityFrameworkCore;
using Peliculas.API.Aplicacion.Actores.Dtos;
using Peliculas.API.Dominio.Actores;
using Peliculas.API.Dominio.GestoresImagenes;
using Peliculas.API.Infraestructura;

namespace Peliculas.API.Aplicacion.Actores
{
    public class ModificadorActor : IServicioAplicacion
    {
        private readonly IActorRepositorio _repositorio;
        private readonly IAlmacenadorArchivoRepositorio _almacenadorArchivo;
        private readonly IProveedorContenedor _proveedorContenedor;
        private readonly ApplicationDbContext _context;

        public ModificadorActor(ApplicationDbContext context,
            IActorRepositorio repositorio,
            IAlmacenadorArchivoRepositorio almacenadorArchivo,
            IProveedorContenedor proveedorContenedor)
        {
            this._context = context;
            this._repositorio = repositorio;
            this._almacenadorArchivo = almacenadorArchivo;
            this._proveedorContenedor = proveedorContenedor;
        }

        public async Task Ejecutar(int id, ActorCreacionDto input)
        {
            Actor actor = await _context.Actores.FirstOrDefaultAsync(actor => actor.Id == id);
            string urlFoto = string.Empty;

            if (input.Foto != null)
            {
                urlFoto = await _almacenadorArchivo.EditarArchivo(this._proveedorContenedor.ObtenerContenedorActores(), input.Foto, actor.Foto);
            }

            if (actor != null)
            {
                actor.Modificar(input.Nombre, input.Biografia, input.FechaNacimiento, urlFoto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
