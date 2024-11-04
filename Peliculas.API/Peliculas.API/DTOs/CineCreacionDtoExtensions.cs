using NetTopologySuite.Geometries;
using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class CineCreacionDtoExtensions
    {
        public static Cine ToEntity(this CineCreacionDTO actorCreacion, GeometryFactory geometryFactory)
        {
            return new Cine
            {
                Nombre = actorCreacion.Nombre,
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(actorCreacion.Longitud, actorCreacion.Latitud))
            };
        }
    }
}
