using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.DTOs
{
    public class CredencialesUsuario
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
