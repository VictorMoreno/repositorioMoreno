using Microsoft.EntityFrameworkCore;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Compartido.Utilidades;
using Peliculas.API.Dominio.Actores;
using Peliculas.API.Dominio.GestoresImagenes;

namespace Peliculas.API.Infraestructura.Actores
{
    public class BaseDatosActorRepositorio : IActorRepositorio
    {
        private const int NUMERO_COINCIDENCIAS = 5;
        private readonly ApplicationDbContext _context;
        private readonly IAlmacenadorArchivoRepositorio _almacenadorArchivo;

        public BaseDatosActorRepositorio(ApplicationDbContext context, IAlmacenadorArchivoRepositorio almacenadorArchivo)
        {
            this._context = context;
            this._almacenadorArchivo = almacenadorArchivo;
        }

        public async Task Actualizar(int id,
            string nombre,
            string biografia,
            DateTime fechaNacimiento,
            string foto)
        {
            //Actor actor = await this._context.Actores.FirstOrDefaultAsync(actor => actor.Id == id);

            //if (foto != null)
            //{
            //    actor.Foto = await this._almacenadorArchivo.EditarArchivo(this._contenedorArchivos, foto, actor.Foto);
            //}

            //if (actor != null)
            //{
            //    actor.Modificar(nombre, biografia, fechaNacimiento, foto);
            //    await this._context.SaveChangesAsync();
            //}
        }

        public async Task<List<Actor>> BuscarPorNombre(string nombre)
        {
            return await this._context.Actores.Where(x => x.Nombre.Contains(nombre))
                .OrderBy(x => x.Nombre)
                .Take(NUMERO_COINCIDENCIAS)
                .ToListAsync();
        }

        public async Task Eliminar(int id)
        {
            var actor = await this._context.Actores.FirstOrDefaultAsync(actor => actor.Id == id);

            if (actor != null)
            {
                this._context.Actores.Remove(actor);
                await this._context.SaveChangesAsync();
            }
        }

        public async Task Guardar(Actor actor)
        {
            this._context.Actores.Add(actor);
            await this._context.SaveChangesAsync();
        }

        public async Task<(int numeroTotal, List<Actor> elementos)> ObtenerActores(PaginacionDto paginacion)
        {
            int cantidadActores = await this._context.Actores.CountAsync();

            var actoresFiltrados = this._context.Actores
                .OrderBy(actor => actor.Nombre)
                .Paginar(paginacion)
                .ToList();

            return (cantidadActores, actoresFiltrados);
        }

        public async Task<Actor> ObtenerPorId(int id) => await this._context.Actores.FirstOrDefaultAsync(actor => actor.Id == id);
    }
}
