using Microsoft.AspNetCore.Identity;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Dominio.Ratings;

public partial class Rating
{
    public int Id { get; set; }
    public int Puntuacion { get; set; }
    public int PeliculaId { get; set; }
    public Pelicula Pelicula { get; set; }
    public string UsuarioId { get; set; }
    public IdentityUser Usuario { get; set; }
}