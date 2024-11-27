using Peliculas.API.Dominio;

namespace Peliculas.API.Excepciones
{
    public class LoginIncorrectoException : DomainError
    {
        public LoginIncorrectoException() 
            : base("Credenciales incorrectas")
        {
        }
    }
}
