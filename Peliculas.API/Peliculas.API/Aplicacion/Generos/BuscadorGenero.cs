using Peliculas.API.Aplicacion.Generos.Dtos;
using Peliculas.API.Dominio.Generos;

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
            List<Genero> generos = await this._repositorio.ObtenerGeneros();
            return generos.ConvertAll(GeneroDtoExtensions.ToDto);
        }
    }
}
