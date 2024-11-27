using System.ComponentModel.DataAnnotations;

namespace Peliculas.API.Aplicacion.Cuentas.Dtos;

public class UsuarioEdicionDto
{
    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Email { get; set; }
}