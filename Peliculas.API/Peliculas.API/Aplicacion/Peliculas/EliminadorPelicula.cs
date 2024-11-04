using Peliculas.API.Repositorios;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class EliminadorPelicula : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _repository;

        public EliminadorPelicula(IPeliculaRepositorio repository)
        {
            this._repository = repository;
        }

        public async Task Ejecutar(int id)
        {
           await this._repository.Eliminar(id);
        }
    }
}
