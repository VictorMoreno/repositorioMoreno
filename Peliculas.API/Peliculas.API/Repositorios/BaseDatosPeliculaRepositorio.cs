using Microsoft.EntityFrameworkCore;
using Peliculas.API.DTOs;
using Peliculas.API.Entidades;
using Peliculas.API.Utilidades;

namespace Peliculas.API.Repositorios
{
    public class BaseDatosPeliculaRepositorio : IPeliculaRepositorio
    {
        // private const int CANTIDAD_MOSTRAR = 6;
        private readonly ApplicationDbContext _context;
        private readonly IAlmacenadorArchivoRepositorio _almacenadorArchivo;
        private readonly IProveedorContenedor _proveedorContenedor;

        public BaseDatosPeliculaRepositorio(ApplicationDbContext context,
            IAlmacenadorArchivoRepositorio almacenadorArchivo,
            IProveedorContenedor proveedorContenedor)
        {
            this._context = context;
            this._almacenadorArchivo = almacenadorArchivo;
            this._proveedorContenedor = proveedorContenedor;
        }

        public async Task Actualizar(int id,
            string titulo,
            string resumen,
            string trailer,
            bool enCines,
            DateTime fechaLanzamiento,
            IFormFile poster,
            List<int> idsGeneros,
            List<int> idsCines,
            List<(int id, string personaje)> actores)
        {
            Pelicula pelicula = await this.ObtenerPorId(id);
            string rutaPoster = string.Empty;

            if (poster != null)
            {
                rutaPoster = await _almacenadorArchivo.EditarArchivo(this._proveedorContenedor.ObtenerContenedorPeliculas(), poster, pelicula.Poster);
            }

            pelicula.Modificar(titulo, resumen, trailer, enCines, fechaLanzamiento, rutaPoster, idsGeneros, idsCines, actores);

            pelicula = EscribirOrdenActores(pelicula);

            await _context.SaveChangesAsync();
        }

        public async Task<List<PeliculaDTO>> Buscar(HttpContext httpContext,
            PaginacionDto paginacion,
            string? titulo,
            bool enCines,
            int? generoId,
            bool proximosEstrenos)
        {
            var query = this._context.Peliculas.AsQueryable();

            if (!string.IsNullOrEmpty(titulo))
            {
                query = query.Where(pelicula => pelicula.Titulo.Contains(titulo));
            }

            if (enCines)
            {
                query = query.Where(pelicula => pelicula.EnCines);
            }

            if (proximosEstrenos)
            {
                var hoy = DateTime.Now;
                query = query.Where(pelicula => pelicula.FechaLanzamiento > hoy);
            }

            if (generoId.HasValue && generoId != 0)
            {
                query = query.Where(pelicula => pelicula.PeliculasGeneros
                .Select(genero => genero.GeneroId)
                .Contains(generoId.Value));
            }

            await httpContext.InsertarParametrosPaginacionEnCabecera(query.Count());

            var peliculas = await query.Paginar(paginacion)
                .Include(pelicula => pelicula.PeliculasActores)
                .ThenInclude(actor => actor.Actor)
                .Include(pelicula => pelicula.PeliculasGeneros)
                .ThenInclude(genero => genero.Genero)
                .Include(pelicula => pelicula.PeliculasCines)
                .ThenInclude(cine => cine.Cine)
                .ToListAsync();

            return peliculas.ConvertAll(pelicula => PeliculaDtoExtensiones.ToDto(pelicula));
        }

        public async Task Eliminar(int id)
        {
            var pelicula = await this._context.Peliculas.FirstOrDefaultAsync(pelicula => pelicula.Id == id);

            if (pelicula != null)
            {
                this._context.Peliculas.Remove(pelicula);
                await this._context.SaveChangesAsync();
                await this._almacenadorArchivo.BorrarArchivo(pelicula.Poster, this._proveedorContenedor.ObtenerContenedorPeliculas());
            }
        }

        public async Task Guardar(Pelicula pelicula)
        {
            this._context.Peliculas.Add(pelicula);
            await this._context.SaveChangesAsync();
        }

        public async Task<List<Pelicula>> ObtenerEnCines()
        {
            return await this._context.Peliculas
                .Where(pelicula => pelicula.EnCines)
                .Include(x => x.PeliculasGeneros).ThenInclude(x => x.Genero)
                .Include(x => x.PeliculasActores).ThenInclude(x => x.Actor)
                .Include(x => x.PeliculasCines).ThenInclude(x => x.Cine)
                .OrderBy(pelicula => pelicula.FechaLanzamiento)
                // .Take(CANTIDAD_MOSTRAR)
                .ToListAsync();
        }

        public async Task<Pelicula> ObtenerPorId(int id)
        {
            return await this._context.Peliculas
                .Include(x => x.PeliculasGeneros).ThenInclude(x => x.Genero)
                .Include(x => x.PeliculasActores).ThenInclude(x => x.Actor)
                .Include(x => x.PeliculasCines).ThenInclude(x => x.Cine)
                .FirstOrDefaultAsync(pelicula => pelicula.Id == id);
        }

        public async Task<List<Pelicula>> ObtenerProximosEstrenos()
        {
            DateTime fechaActual = DateTime.Now;

            return await this._context.Peliculas.Where(pelicula => pelicula.FechaLanzamiento > fechaActual)
                .Include(x => x.PeliculasGeneros).ThenInclude(x => x.Genero)
                .Include(x => x.PeliculasActores).ThenInclude(x => x.Actor)
                .Include(x => x.PeliculasCines).ThenInclude(x => x.Cine)
                .OrderBy(pelicula => pelicula.FechaLanzamiento)
                // .Take(CANTIDAD_MOSTRAR)
                .ToListAsync();
        }

        //public async Task<(int numeroTotal, List<Actor> elementos)> ObtenerActores(PaginacionDto paginacion)
        //{
        //    int cantidadActores = await this._context.Actores.CountAsync();

        //    var actoresFiltrados = this._context.Actores
        //        .OrderBy(actor => actor.Nombre)
        //        .Paginar(paginacion)
        //        .ToList();

        //    return (cantidadActores, actoresFiltrados);
        //}

        private Pelicula EscribirOrdenActores(Pelicula pelicula)
        {
            if (pelicula.PeliculasActores != null)
            {
                for (int i = 0; i < pelicula.PeliculasActores.Count; i++)
                {
                    pelicula.PeliculasActores[i].Orden = i;
                }
            }

            return pelicula;
        }
    }
}
