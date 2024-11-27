using Peliculas.API.Aplicacion.Cines.Dtos;
using Peliculas.API.Aplicacion.Generos.Dtos;

namespace Peliculas.API.App.Dtos
{
    public class PeliculasPostGetDto
    {
        public List<GeneroDto> Generos { get; set; }
        public List<CineDto> Cines { get; set; }
    }
}
