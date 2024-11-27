using Peliculas.API.Aplicacion.Generos.Dtos;
using Peliculas.API.Dominio.Generos;

namespace Peliculas.API.Aplicacion.Generos
{
    public class EncontradorGenero : IServicioAplicacion
    {
        private readonly IGeneroRepositorio _repositorio;

        public EncontradorGenero(IGeneroRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task<GeneroDto> Ejecutar(int id)
        {
            Genero genero = await this._repositorio.ObtenerPorId(id);

            if (genero == null)
            {
                throw new FileNotFoundException();
            }

            return genero.ToDto();
        }
    }
}
