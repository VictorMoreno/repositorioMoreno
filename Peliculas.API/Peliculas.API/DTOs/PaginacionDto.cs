namespace Peliculas.API.DTOs
{
    public class PaginacionDto
    {
        private int _registrosPorPagina = 10;
        private readonly int _cantidadMaximaRegistrosPorPagina = 50;
        public int Pagina { get; set; }
        public int RegistrosPorPagina
        {
            get
            {
                return _registrosPorPagina;
            }
            set
            {
                _registrosPorPagina = (value > _cantidadMaximaRegistrosPorPagina) ? _cantidadMaximaRegistrosPorPagina : value;
            }
        }
    }
}
