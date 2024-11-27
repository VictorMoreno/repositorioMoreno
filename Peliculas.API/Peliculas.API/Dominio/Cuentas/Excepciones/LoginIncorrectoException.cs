namespace Peliculas.API.Dominio.Cuentas.Excepciones
{
    public class LoginIncorrectoException : DomainError
    {
        public LoginIncorrectoException() 
            : base("Credenciales incorrectas")
        {
        }
    }
}
