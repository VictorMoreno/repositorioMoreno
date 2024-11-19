namespace Peliculas.API.DTOs
{
    public class PeliculasPostGetDto
    {
        public List<GeneroDto> Generos { get; set; }
        public List<CineDto> Cines { get; set; }
    }
}
