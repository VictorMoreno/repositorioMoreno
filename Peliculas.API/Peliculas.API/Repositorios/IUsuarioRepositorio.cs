using Microsoft.AspNetCore.Identity;
using Peliculas.API.DTOs;

namespace Peliculas.API.Repositorios;

public interface IUsuarioRepositorio
{
    Task<(int numeroTotal, List<IdentityUser> usuarios)> BuscarPaginado(PaginacionDto paginacion);
    Task HacerAdministrador(string idUsuario);
    Task QuitarAdministrador(string idUsuario);
}