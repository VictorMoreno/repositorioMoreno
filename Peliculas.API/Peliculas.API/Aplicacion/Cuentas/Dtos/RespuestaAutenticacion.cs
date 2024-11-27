namespace Peliculas.API.Aplicacion.Cuentas.Dtos
{
    public class RespuestaAutenticacion
    {
        public string Token { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
