using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.Aplicacion.Actores.Dtos
{
    public class ActorCreacionDto
    {
        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(maximumLength: 200)]
        public string Nombre { get; set; }

        public string? Biografia { get; set; }

        [Required(ErrorMessage = "El campo fecha de nacimiento es requerido")]
        public DateTime FechaNacimiento { get; set; }

        public IFormFile? Foto { get; set; }
    }
}