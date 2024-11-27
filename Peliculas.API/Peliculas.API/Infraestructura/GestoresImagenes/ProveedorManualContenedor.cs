using Peliculas.API.Dominio.GestoresImagenes;

namespace Peliculas.API.Infraestructura.GestoresImagenes
{
    public class ProveedorManualContenedor : IProveedorContenedor
    {
        public string ObtenerContenedorActores() => "actores";
        public string ObtenerContenedorPeliculas() => "peliculas";
    }
}
