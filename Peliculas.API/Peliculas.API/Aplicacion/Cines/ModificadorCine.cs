using NetTopologySuite.Geometries;
using Peliculas.API.Dominio.Cines;

namespace Peliculas.API.Aplicacion.Cines;

public class ModificadorCine : IServicioAplicacion
{
    private readonly ICineRepositorio _repository;
    private readonly GeometryFactory _geometryFactory;

    public ModificadorCine(ICineRepositorio repository, GeometryFactory geometryFactory)
    {
        this._repository = repository;
        this._geometryFactory = geometryFactory;
    }

    public async Task Ejecutar(int id, string nombre, double latitud, double longitud)
    {
        var cine = await this._repository.ObtenerPorId(id);

        cine.Modificar(nombre, this._geometryFactory.CreatePoint(new Coordinate(longitud, latitud)));

        await this._repository.Actualizar(cine);
    }
}