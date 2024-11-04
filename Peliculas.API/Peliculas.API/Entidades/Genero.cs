using Peliculas.API.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.Entidades
{
    public partial class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50)]
        [PrimeraLetraMayusculaAttribute]
        public string Nombre { get; set; }
        public List<PeliculasGeneros> PeliculasGeneros { get; set; }
    }
}
