namespace Peliculas.API.Dominio;

public class DomainError : Exception
{
    public DomainError(string mensaje)
        : base(mensaje)
    {
    }
}