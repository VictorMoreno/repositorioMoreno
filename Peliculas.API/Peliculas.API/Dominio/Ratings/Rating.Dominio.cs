namespace Peliculas.API.Dominio.Ratings;

public partial class Rating
{
    public static Rating Crear(int puntuacion, int idPelicula, string idUsuario)
    {
        var nuevoRating = new Rating
        {
            PeliculaId = idPelicula,
            Puntuacion = puntuacion,
            UsuarioId = idUsuario
        };

        return nuevoRating;
    }

    public void Modificar(int puntuacion)
    {
        this.Puntuacion = puntuacion;
    }
}