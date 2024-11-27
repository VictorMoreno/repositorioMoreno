using Peliculas.API.Aplicacion.Generos.Dtos;
using Peliculas.API.Dominio.Generos;

namespace Peliculas.API.Aplicacion.Generos
{
    public class ModificadorGenero : IServicioAplicacion
    {
        private readonly IGeneroRepositorio _repositorio;

        public ModificadorGenero(IGeneroRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task Ejecutar(int id, GeneroCreacionDto genero)
        {
            await this._repositorio.Actualizar(id, genero.Nombre);
        }
    }
}
