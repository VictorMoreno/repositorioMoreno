using Microsoft.AspNetCore.Identity;

namespace Peliculas.API.Entidades;

public partial class Rating
{
    public int Id { get; set; }
    public int Puntuacion { get; set; }
    public int PeliculaId { get; set; }
    public Pelicula Pelicula { get; set; }
    public string UsuarioId { get; set; }
    public IdentityUser Usuario { get; set; }
}