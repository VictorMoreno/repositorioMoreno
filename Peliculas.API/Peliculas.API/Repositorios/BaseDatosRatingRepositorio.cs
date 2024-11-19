using Microsoft.EntityFrameworkCore;
using Peliculas.API.Entidades;

namespace Peliculas.API.Repositorios;

public class BaseDatosRatingRepositorio : IRatingRepositorio
{
    private readonly ApplicationDbContext _context;

    public BaseDatosRatingRepositorio(ApplicationDbContext context)
    {
        this._context = context;
    }

    public async Task<Rating?> ObtenerRatingUsuario(string idUsuario, int idPelicula)
    {
        return await this._context.Ratings.FirstOrDefaultAsync(rating =>
            rating.UsuarioId == idUsuario && rating.PeliculaId == idPelicula);
    }

    public async Task<double> ObtenerMediaRatings(int idPelicula)
    {
        return await this._context.Ratings.Where(x => x.PeliculaId == idPelicula)
            .AverageAsync(x => x.Puntuacion);
    }

    public Task<bool> ExisteRatingPelicula(int idPelicula)
    {
        return this._context.Ratings.AnyAsync(x => x.PeliculaId == idPelicula);
    }

    public async Task Guardar(Rating rating)
    {
        await this._context.Ratings.AddAsync(rating);
        await this._context.SaveChangesAsync();
    }

    public async Task Actualizar(Rating ratingActual)
    {
        await this._context.SaveChangesAsync();
    }
}