using Microsoft.AspNetCore.Identity;

namespace Peliculas.API.Aplicacion.Cuentas;

public class ModificadorCuenta : IServicioAplicacion
{
    private readonly UserManager<IdentityUser> _userManager;

    public ModificadorCuenta(UserManager<IdentityUser> userManager)
    {
        this._userManager = userManager;
    }

    public async Task Ejecutar(string id, string nuevoEmail)
    {
        IdentityUser? usuario = await _userManager.FindByIdAsync(id).ConfigureAwait(false);

        if (usuario == null)
        {
            throw new Exception("Email no encontrado");
        }

        usuario.Email = nuevoEmail;
        usuario.UserName = nuevoEmail;

        IdentityResult resultado = await _userManager.UpdateAsync(usuario);

        if (!resultado.Succeeded)
        {
            throw new Exception("Se ha producido un error al actualizar el email.");
        }
    }
}