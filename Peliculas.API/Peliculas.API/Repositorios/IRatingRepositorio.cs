using Peliculas.API.Entidades;

namespace Peliculas.API.Repositorios;

public interface IRatingRepositorio
{
    Task<Rating?> ObtenerRating(string idUsuario, int idPelicula);
    Task Guardar(Rating rating);
    Task Actualizar(Rating ratingActual);
}