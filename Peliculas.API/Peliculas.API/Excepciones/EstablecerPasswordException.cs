using Peliculas.API.Dominio;

namespace Peliculas.API.Excepciones
{
    public class EstablecerPasswordException : DomainError
    {
        public EstablecerPasswordException() 
            : base("No se ha podido establecer la nueva contraseña.")
        {
        }
    }
}
