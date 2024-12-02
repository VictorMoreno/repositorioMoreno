using Microsoft.AspNetCore.Identity;

namespace Peliculas.API.Dominio.Cuentas.Excepciones
{
    public class CreacionUsuarioException : DomainError
    {
        public CreacionUsuarioException(IEnumerable<IdentityError> errores)
            : base(
                "Las contraseñas deben tener al menos 6 caracteres, incluyendo al menos una letra mayúscula, una letra minúscula, un número y un símbolo.")
        {
        }
    }
}