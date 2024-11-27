using Peliculas.API.Aplicacion.Cines.Dtos;
using Peliculas.API.Aplicacion.Generos.Dtos;

namespace Peliculas.API.Aplicacion.Peliculas.Dtos
{
    public class PeliculaDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Trailer { get; set; }
        public bool EnCines { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string Poster { get; set; }
        public List<GeneroDto> Generos { get; set; }
        public List<PeliculaActorDto> Actores { get; set; }
        public List<CineDto> Cines { get; set; }
        public int VotoUsuario { get; set; }
        public double VotoPromedio { get; set; }
    }
}
