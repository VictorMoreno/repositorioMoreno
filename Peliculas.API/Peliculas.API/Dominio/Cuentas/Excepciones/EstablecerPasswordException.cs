namespace Peliculas.API.Dominio.Cuentas.Excepciones
{
    public class EstablecerPasswordException : DomainError
    {
        public EstablecerPasswordException() 
            : base("No se ha podido establecer la nueva contraseña.")
        {
        }
    }
}
