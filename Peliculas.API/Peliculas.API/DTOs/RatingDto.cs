using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.DTOs;

public class RatingDto
{
    public int PeliculaId { get; set; }
    [Range(1,5)]
    public int Puntuacion { get; set; }
}