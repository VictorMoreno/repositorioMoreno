namespace Peliculas.API.Dominio.Ratings;

public interface IRatingRepositorio
{
    Task<Rating?> ObtenerRatingUsuario(string idUsuario, int idPelicula);
    Task<double> ObtenerMediaRatings(int idPelicula);
    Task<bool> ExisteRatingPelicula(int idPelicula);
    Task Guardar(Rating rating);
    Task Actualizar(Rating ratingActual);
}