using Microsoft.EntityFrameworkCore;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Compartido.Utilidades;
using Peliculas.API.Dominio.Generos;

namespace Peliculas.API.Infraestructura.Generos
{
    public class BaseDatosGeneroRepositorio : IGeneroRepositorio
    {
        private readonly ApplicationDbContext _context;

        public BaseDatosGeneroRepositorio(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<(int numeroTotal, List<Genero> elementos)> ObtenerTodosLosGeneros(PaginacionDto paginacion)
        {
            int cantidadGeneros = await this._context.Generos.CountAsync();

            var generosFiltrados = this._context.Generos
                .OrderBy(genero => genero.Nombre)
                .Paginar(paginacion)
                .ToList();

            return (cantidadGeneros, generosFiltrados);
        }

        public async Task<List<Genero>> ObtenerTodosLosGeneros()
        {
            return await this._context.Generos
                .OrderBy(genero => genero.Nombre)
                .ToListAsync();
        }

        public async Task<Genero> ObtenerPorId(int id) =>
            await this._context.Generos.FirstAsync(genero => genero.Id == id);

        public async Task Guardar(Genero genero)
        {
            this._context.Generos.Add(genero);
            await this._context.SaveChangesAsync();
        }

        public async Task Actualizar(int id, string nombre)
        {
            Genero? genero = await this._context.Generos.FirstOrDefaultAsync(genero => genero.Id == id);

            if (genero != null)
            {
                genero.Modificar(nombre);
                await this._context.SaveChangesAsync();
            }
        }

        public async Task Eliminar(int id)
        {
            var genero = await this._context.Generos.FirstOrDefaultAsync(genero => genero.Id == id);

            if (genero != null)
            {
                this._context.Generos.Remove(genero);
                await this._context.SaveChangesAsync();
            }
        }

        public async Task<List<Genero>> ObtenerNoContenidos(List<int> ids)
        {
            return await _context.Generos
                .Where(genero => !ids.Contains(genero.Id))
                .ToListAsync();
        }
    }
}