using Microsoft.AspNetCore.Identity;

namespace Peliculas.API.Dominio.Cuentas.Excepciones
{
    public class CreacionUsuarioException : DomainError
    {
        private IEnumerable<IdentityError> _errores;
        public IEnumerable<IdentityError> Errores => this._errores;
        public CreacionUsuarioException(IEnumerable<IdentityError> errores) 
            : base("Error durante la creación del usuario")
        {
            this._errores = errores;
        }
    }
}
