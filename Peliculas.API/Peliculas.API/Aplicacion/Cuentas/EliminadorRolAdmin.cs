using Peliculas.API.Repositorios;

namespace Peliculas.API.Aplicacion.Cuentas;

public class EliminadorRolAdmin : IServicioAplicacion
{
    private readonly IUsuarioRepositorio _repositorio;

    public EliminadorRolAdmin(IUsuarioRepositorio repositorio)
    {
        this._repositorio = repositorio;
    }

    public async Task Ejecutar(string idUsuario)
    {
        await this._repositorio.QuitarAdministrador(idUsuario);
    }
}