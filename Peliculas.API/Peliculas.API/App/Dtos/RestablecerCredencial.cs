using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.App.Dtos;

public class RestablecerCredencial
{
    [EmailAddress] [Required] public string Email { get; set; }
    [Required] public string Password { get; set; }
    [Required] public string Token { get; set; }
}