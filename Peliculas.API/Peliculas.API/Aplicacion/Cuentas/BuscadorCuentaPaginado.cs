using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;
using Peliculas.API.Utilidades;

namespace Peliculas.API.Aplicacion.Cuentas;

public class BuscadorCuentaPaginado : IServicioAplicacion
{
    private readonly IUsuarioRepositorio _repositorio;

    public BuscadorCuentaPaginado(IUsuarioRepositorio repositorio)
    {
        this._repositorio = repositorio;
    }

    public async Task<List<UsuarioDto>> Ejecutar(PaginacionDto paginacion, HttpContext httpContext)
    {
        var registros = await this._repositorio.BuscarPaginado(paginacion);
        await httpContext.InsertarParametrosPaginacionEnCabecera(registros.numeroTotal);
        return registros.usuarios.ConvertAll(UsuarioDtoExtensiones.ToDto);
    }
}