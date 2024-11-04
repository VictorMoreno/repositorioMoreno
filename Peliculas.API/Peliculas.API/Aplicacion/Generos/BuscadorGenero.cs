using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;

namespace Peliculas.API.Aplicacion.Generos
{
    public class BuscadorGenero : IServicioAplicacion
    {
        private readonly IGeneroRepositorio _repositorio;

        public BuscadorGenero(IGeneroRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task<List<GeneroDto>> Ejecutar()
        {
            var generos = await this._repositorio.ObtenerTodosLosGeneros();
            return generos.ConvertAll(GeneroDtoExtensions.ToDto);
        }
    }
}
