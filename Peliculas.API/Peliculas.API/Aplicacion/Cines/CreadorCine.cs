using NetTopologySuite.Geometries;
using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;

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

        public async Task Ejecutar(CineCreacionDto input)
        {
            await this._repository.Guardar(input.ToEntity(this._geometryFactory));
        }
    }
}
