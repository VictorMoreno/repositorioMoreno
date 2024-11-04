using Microsoft.AspNetCore.Identity;

namespace Peliculas.API.Excepciones
{
    public class LoginIncorrectoException : Exception
    {
        public LoginIncorrectoException() 
            : base("Credenciales incorrectas")
        {
        }
    }
}
