using Peliculas.API.Aplicacion.Generos.Dtos;
using Peliculas.API.Dominio.Generos;

namespace Peliculas.API.Aplicacion.Generos
{
    public class CreadorGenero : IServicioAplicacion
    {
        private readonly IGeneroRepositorio _repositorio;

        public CreadorGenero(IGeneroRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task Ejecutar(GeneroCreacionDto genero)
        {
            await this._repositorio.Guardar(genero.ToEntity());
        }
    }
}
