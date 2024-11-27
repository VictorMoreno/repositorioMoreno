using Peliculas.API.Dominio.Generos;

namespace Peliculas.API.Aplicacion.Generos
{
    public class EliminadorGenero : IServicioAplicacion
    {
        private readonly IGeneroRepositorio _repositorio;

        public EliminadorGenero(IGeneroRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public async Task Ejecutar(int id)
        {
            await this._repositorio.Eliminar(id);
        }
    }
}
