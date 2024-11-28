using NetTopologySuite.Geometries;
using Peliculas.API.Dominio.Cines;

namespace Peliculas.API.Aplicacion.Cines
{
    public class CreadorCine : IServicioAplicacion
    {
        private readonly ICineRepositorio _repository;
        private readonly GeometryFactory _geometryFactory;

        public CreadorCine(ICineRepositorio repository, GeometryFactory geometryFactory)
        {
            this._repository = repository;
            this._geometryFactory = geometryFactory;
        }

        public async Task Ejecutar(string nombre, double latitud, double longitud)
        {
            Point? puntoGeografico = this._geometryFactory.CreatePoint(new Coordinate(longitud, latitud));
            Cine cine = Cine.Crear(nombre, puntoGeografico);

            await this._repository.Guardar(cine);
        }
    }
}