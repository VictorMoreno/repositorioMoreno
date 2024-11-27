using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.App.Dtos;

public class RatingDto
{
    public int IdPelicula { get; set; }
    [Range(1,5)]
    public int Puntuacion { get; set; }
}