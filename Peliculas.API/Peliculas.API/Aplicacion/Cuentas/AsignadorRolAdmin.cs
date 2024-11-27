using Peliculas.API.Dominio.Cuentas;

namespace Peliculas.API.Aplicacion.Cuentas;

public class AsignadorRolAdmin : IServicioAplicacion
{
    private readonly IUsuarioRepositorio _repositorio;

    public AsignadorRolAdmin(IUsuarioRepositorio repositorio)
    {
        this._repositorio = repositorio;
    }

    public async Task Ejecutar(string idUsuario)
    {
        await this._repositorio.HacerAdministrador(idUsuario);
    }
}