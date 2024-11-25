using Microsoft.AspNetCore.Identity;
using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;

namespace Peliculas.API.Aplicacion.Cuentas;

public class ObtenedorCuenta : IServicioAplicacion
{
    private readonly IUsuarioRepositorio _repositorio;

    public ObtenedorCuenta(IUsuarioRepositorio repositorio)
    {
        this._repositorio = repositorio;
    }

    public async Task<UsuarioDto> Ejecutar(string id)
    {
        IdentityUser usuario = await this._repositorio.Obtener(id).ConfigureAwait(false);
        return usuario.ToDto();
    }
}