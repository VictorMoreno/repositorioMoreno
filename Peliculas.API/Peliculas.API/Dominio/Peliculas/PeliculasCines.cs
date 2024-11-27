using Peliculas.API.Dominio.Cines;

namespace Peliculas.API.Dominio.Peliculas
{
    public class PeliculasCines
    {
        public int PeliculaId { get; set; }
        public int CineId { get; set; }
        public Pelicula Pelicula { get; set; }
        public Cine Cine { get; set; }
    }
}
