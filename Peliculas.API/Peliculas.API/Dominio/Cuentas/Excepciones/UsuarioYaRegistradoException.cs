namespace Peliculas.API.Dominio.Cuentas.Excepciones
{
    public class UsuarioYaRegistradoException : DomainError
    {
        public UsuarioYaRegistradoException()
            : base("Usuario ya registrado")
        {
        }
    }
}