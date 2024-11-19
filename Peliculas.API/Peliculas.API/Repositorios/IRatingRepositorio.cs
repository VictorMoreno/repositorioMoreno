using Peliculas.API.Entidades;

namespace Peliculas.API.Repositorios;

public interface IRatingRepositorio
{
    Task<Rating?> ObtenerRatingUsuario(string idUsuario, int idPelicula);
    Task<double> ObtenerMediaRatings(int idPelicula);
    Task<bool> ExisteRatingPelicula(int idPelicula);
    Task Guardar(Rating rating);
    Task Actualizar(Rating ratingActual);
}