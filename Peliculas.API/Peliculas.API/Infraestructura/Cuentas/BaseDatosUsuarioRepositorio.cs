using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Compartido.Utilidades;
using Peliculas.API.Dominio.Cuentas;

namespace Peliculas.API.Infraestructura.Cuentas;

public class BaseDatosUsuarioRepositorio : IUsuarioRepositorio
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public BaseDatosUsuarioRepositorio(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        this._context = context;
        this._userManager = userManager;
    }

    public async Task<(int numeroTotal, List<IdentityUser> usuarios)> BuscarPaginado(PaginacionDto paginacion)
    {
        var queryable = this._context.Users.AsQueryable();
        var numeroTotal = queryable.Count();

        List<IdentityUser> usuarios = await queryable.OrderBy(usuario => usuario.Email)
            .Paginar(paginacion)
            .ToListAsync();

        return (numeroTotal, usuarios);
    }

    public async Task<IdentityUser> Obtener(string id)
    {
        return await this._context.Users.FirstAsync(usuario => usuario.Id == id).ConfigureAwait(false);
    }

    public async Task HacerAdministrador(string idUsuario)
    {
        IdentityUser? usuario = await this._userManager.FindByIdAsync(idUsuario);

        if (usuario != null)
        {
            await this._userManager.AddClaimAsync(usuario, new Claim("role", "admin"));
        }
    }

    public async Task QuitarAdministrador(string idUsuario)
    {
        IdentityUser? usuario = await this._userManager.FindByIdAsync(idUsuario);

        if (usuario != null)
        {
            await this._userManager.RemoveClaimAsync(usuario, new Claim("role", "admin"));
        }
    }
}