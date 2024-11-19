using Peliculas.API.DTOs;
using Peliculas.API.Entidades;
using Peliculas.API.Repositorios;

namespace Peliculas.API.Aplicacion.Actores
{
    public class BuscadorPeliculasActor : IServicioAplicacion
    {
        private readonly IActorRepositorio _repositorio;

        public BuscadorPeliculasActor(IActorRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task<List<PeliculaActorDto>> Ejecutar(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return new List<PeliculaActorDto>();
            }

            List<Actor> peliculas = await this._repositorio.BuscarPorNombre(nombre);
            return peliculas.ConvertAll(PeliculaActorDtoExtensiones.ToDto);
        }
    }
}
