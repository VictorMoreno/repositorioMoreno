using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class ModificadorPelicula : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _repositorio;

        public ModificadorPelicula(IPeliculaRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task Ejecutar(int id, PeliculaCreacionDto input)
        {
            await this._repositorio.Actualizar(id,
                input.Titulo,
                input.Resumen,
                input.Trailer,
                input.EnCines,
                input.FechaLanzamiento,
                input.Poster,
                input.GenerosIds,
                input.CinesIds,
                input.Actores.Select(actor => (actor.id, actor.Personaje)).ToList());
        }
    }
}
