using Peliculas.API.Dominio.Cines;

namespace Peliculas.API.Aplicacion.Cines;

public class EliminadorCine : IServicioAplicacion
{
    private readonly ICineRepositorio _repositorio;

    public EliminadorCine(ICineRepositorio repositorio)
    {
        this._repositorio = repositorio;
    }

    public async Task Ejecutar(int id)
    {
        Cine cine = await _repositorio.ObtenerPorId(id);

        await this._repositorio.Eliminar(cine).ConfigureAwait(false);
    }
}