namespace Peliculas.API.Aplicacion.Peliculas.Dtos
{
    public class LandingPageDto
    {
        public List<PeliculaDto> EnCines { get; set; }
        public List<PeliculaDto> ProximosEstrenos { get; set; }
    }
}
