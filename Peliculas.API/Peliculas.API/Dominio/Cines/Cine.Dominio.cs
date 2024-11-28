using NetTopologySuite.Geometries;

namespace Peliculas.API.Dominio.Cines
{
    public partial class Cine
    {
        public Cine(int id, string nombre, Point ubicacion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Ubicacion = ubicacion;
        }

        public static Cine Crear(string nombre, Point ubicacion) => new Cine(0, nombre, ubicacion);

        public void Modificar(string nombre, Point ubicacion)
        {
            this.Nombre = nombre;
            this.Ubicacion = ubicacion;
        }
    }
}
