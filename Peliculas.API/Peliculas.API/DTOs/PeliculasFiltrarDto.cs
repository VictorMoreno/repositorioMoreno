namespace Peliculas.API.DTOs
{
    public class PeliculasFiltrarDto
    {
        public int Pagina { get; set; }
        public int RegistrosPorPagina { get; set; }
        public PaginacionDto PaginacionDto
        {
            get
            {
                return new PaginacionDto { Pagina = this.Pagina, RegistrosPorPagina = this.RegistrosPorPagina };
            }
        }
        public string? Titulo { get; set; }
        public int? GeneroId { get; set; }
        public bool EnCines { get; set; }
        public bool ProximosEstrenos { get; set; }
    }
}
