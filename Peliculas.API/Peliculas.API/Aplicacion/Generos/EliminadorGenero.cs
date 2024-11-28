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
            Genero genero = await this._repositorio.ObtenerPorId(id);

            await this._repositorio.Eliminar(genero);
        }
    }
}