using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.App.Dtos;

public class SolicitudRestablecerCredencial
{
    [EmailAddress] [Required] public string Email { get; set; }
}