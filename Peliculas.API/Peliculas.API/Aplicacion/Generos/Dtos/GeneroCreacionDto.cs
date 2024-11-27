using System.ComponentModel.DataAnnotations;
using Peliculas.API.Compartido.Utilidades.Validaciones;

namespace Peliculas.API.Aplicacion.Generos.Dtos
{
    public class GeneroCreacionDto
    {
        public GeneroCreacionDto(string nombre)
        {
            this.Nombre = nombre;
        }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
    }
}
