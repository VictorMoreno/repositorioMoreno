using NetTopologySuite.Geometries;
using Peliculas.API.Dominio.Cines;

namespace Peliculas.API.Aplicacion.Cines.Dtos
{
    public static class CineCreacionDtoExtensions
    {
        public static Cine ToEntity(this CineCreacionDto actorCreacion, GeometryFactory geometryFactory)
        {
            return new Cine
            {
                Nombre = actorCreacion.Nombre,
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(actorCreacion.Longitud, actorCreacion.Latitud))
            };
        }
    }
}
