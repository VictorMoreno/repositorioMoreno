using System.ComponentModel.DataAnnotations;
using Peliculas.API.Compartido.Utilidades.Validaciones;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Dominio.Generos
{
    public partial class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public List<PeliculasGeneros> PeliculasGeneros { get; set; }
    }
}
