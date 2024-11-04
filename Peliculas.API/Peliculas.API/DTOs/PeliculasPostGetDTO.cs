namespace Peliculas.API.DTOs
{
    public class PeliculasPostGetDTO
    {
        public List<GeneroDto> Generos { get; set; }
        public List<CineDto> Cines { get; set; }
    }
}
