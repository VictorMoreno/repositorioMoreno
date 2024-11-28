using Microsoft.EntityFrameworkCore;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Compartido.Utilidades;
using Peliculas.API.Dominio.Actores;

namespace Peliculas.API.Infraestructura.Actores
{
    public class BaseDatosActorRepositorio : IActorRepositorio
    {
        private const int NumeroCoincidencias = 5;
        private readonly ApplicationDbContext _context;

        public BaseDatosActorRepositorio(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task Actualizar(Actor actor)
        {
            await this._context.SaveChangesAsync();
        }

        public async Task<List<Actor>> BuscarPorNombre(string nombre)
        {
            return await this._context.Actores.Where(x => x.Nombre.Contains(nombre))
                .OrderBy(x => x.Nombre)
                .Take(NumeroCoincidencias)
                .ToListAsync();
        }

        public async Task Eliminar(Actor actor)
        {
            this._context.Actores.Remove(actor);
            await this._context.SaveChangesAsync();
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

        public async Task<Actor> ObtenerPorId(int id) =>
            await this._context.Actores.FirstAsync(actor => actor.Id == id);
    }
}