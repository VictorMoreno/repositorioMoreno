namespace Peliculas.API.Excepciones
{
    public class EstablecerPasswordException : Exception
    {
        public EstablecerPasswordException() 
            : base("No se ha podido establecer la nueva contraseña.")
        {
        }
    }
}
