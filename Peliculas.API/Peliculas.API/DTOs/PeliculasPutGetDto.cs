namespace Peliculas.API.DTOs
{
    public class PeliculasPutGetDto
    {
        public PeliculaDTO Pelicula { get; set; }
        public List<GeneroDto> GenerosSeleccionados { get; set; }
        public List<GeneroDto> GenerosNoSeleccionados { get; set; }
        public List<CineDto> CinesSeleccionados { get; set; }
        public List<CineDto> CinesNoSeleccionados { get; set; }
        public List<PeliculaActorDTO> Actores { get; set; }
    }
}
