using Peliculas.API.DTOs;
using Peliculas.API.Entidades;
using Peliculas.API.Repositorios;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class EncontradorPelicula : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _repository;

        public EncontradorPelicula(IPeliculaRepositorio repository)
        {
            this._repository = repository;
        }

        public async Task<PeliculaDTO> Ejecutar(int id)
        {
            Pelicula pelicula = await this._repository.ObtenerPorId(id);

            if (pelicula == null)
            {
                throw new FileNotFoundException();
            }

            return pelicula.ToDto();
        }
    }
}
