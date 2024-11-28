using Microsoft.EntityFrameworkCore;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Compartido.Utilidades;
using Peliculas.API.Dominio.Cines;

namespace Peliculas.API.Infraestructura.Cines
{
    public class BaseDatosCineRepositorio : ICineRepositorio
    {
        private readonly ApplicationDbContext _context;

        public BaseDatosCineRepositorio(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task Guardar(Cine cine)
        {
            this._context.Cines.Add(cine);
            await this._context.SaveChangesAsync();
        }

        public async Task<(int numeroTotal, List<Cine> elementos)> ObtenerCines(PaginacionDto paginacion)
        {
            int cantidadCines = await this._context.Cines.CountAsync();

            var cinesFiltrados = this._context.Cines
                .OrderBy(actor => actor.Nombre)
                .Paginar(paginacion)
                .ToList();

            return (cantidadCines, cinesFiltrados);
        }

        public async Task<List<Cine>> ObtenerCines()
        {
            return await this._context.Cines
                .OrderBy(actor => actor.Nombre)
                .ToListAsync();
        }

        public async Task<Cine> ObtenerPorId(int id) => await this._context.Cines.FirstAsync(actor => actor.Id == id);

        public async Task<List<Cine>> ObtenerNoContenidos(List<int> ids)
        {
            return await this._context.Cines
                .Where(cine => !ids.Contains(cine.Id))
                .ToListAsync();
        }

        public async Task Eliminar(int id)
        {
            var cine = await this._context.Cines.FirstOrDefaultAsync(cine => cine.Id == id);

            if (cine != null)
            {
                this._context.Cines.Remove(cine);
                await this._context.SaveChangesAsync();
            }
        }

        public async Task Actualizar(Cine cine)
        {
            await this._context.SaveChangesAsync();
        }
    }
}