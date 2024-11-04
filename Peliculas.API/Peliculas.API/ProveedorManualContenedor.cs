namespace Peliculas.API
{
    public class ProveedorManualContenedor : IProveedorContenedor
    {
        public string ObtenerContenedorActores() => "actores";
        public string ObtenerContenedorPeliculas() => "peliculas";
    }
}
