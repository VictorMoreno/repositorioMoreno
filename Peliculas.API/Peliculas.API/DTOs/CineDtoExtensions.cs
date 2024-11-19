using Peliculas.API.Entidades;

namespace Peliculas.API.DTOs
{
    public static class CineDtoExtensions
    {
        public static CineDto ToDto(this Cine cine)
            => new CineDto
            {
                Id = cine.Id,
                Nombre = cine.Nombre,
                Latitud = cine.Ubicacion.Y,
                Longitud = cine.Ubicacion.X
            };
    }
}
