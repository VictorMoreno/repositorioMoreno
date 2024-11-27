using Microsoft.AspNetCore.Identity;
using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.Dominio.Cuentas;

public interface IUsuarioRepositorio
{
    Task<(int numeroTotal, List<IdentityUser> usuarios)> BuscarPaginado(PaginacionDto paginacion);
    Task HacerAdministrador(string idUsuario);
    Task QuitarAdministrador(string idUsuario);
    Task<IdentityUser> Obtener(string id);
}