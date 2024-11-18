using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.DTOs;

public class SolicitudRestablecerCredencial
{
    [EmailAddress] [Required] public string Email { get; set; }
}