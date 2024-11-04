using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.DTOs
{
    public class ActorCreacionDto
    {
        //public ActorCreacionDto(string nombre, string biografia, DateTime fechaNacimiento, IFormFile foto)
        //{
        //    this.Nombre = nombre;
        //    this.Biografia = biografia;
        //    this.FechaNacimiento = fechaNacimiento;
        //    this.Foto = foto;
        //}

        [Required]
        [StringLength(maximumLength: 200)]
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public IFormFile Foto { get; set; }
    }
}
