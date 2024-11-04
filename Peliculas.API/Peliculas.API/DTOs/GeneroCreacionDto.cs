using Peliculas.API.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.DTOs
{
    public class GeneroCreacionDto
    {
        public GeneroCreacionDto(string nombre)
        {
            this.Nombre = nombre;
        }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50)]
        [PrimeraLetraMayusculaAttribute]
        public string Nombre { get; set; }
    }
}
