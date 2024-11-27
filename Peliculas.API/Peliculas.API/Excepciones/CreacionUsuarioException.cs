using Microsoft.AspNetCore.Identity;
using Peliculas.API.Dominio;

namespace Peliculas.API.Excepciones
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
