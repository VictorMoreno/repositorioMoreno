using Peliculas.API.Aplicacion.Cines.Dtos;
using Peliculas.API.Aplicacion.Generos.Dtos;

namespace Peliculas.API.Aplicacion.Peliculas.Dtos
{
    public class PeliculasPutGetDto
    {
        public PeliculaDto Pelicula { get; set; }
        public List<GeneroDto> GenerosSeleccionados { get; set; }
        public List<GeneroDto> GenerosNoSeleccionados { get; set; }
        public List<CineDto> CinesSeleccionados { get; set; }
        public List<CineDto> CinesNoSeleccionados { get; set; }
        public List<PeliculaActorDto> Actores { get; set; }
    }
}
