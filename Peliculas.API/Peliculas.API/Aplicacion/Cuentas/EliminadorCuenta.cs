using Microsoft.AspNetCore.Identity;

namespace Peliculas.API.Aplicacion.Cuentas;

public class EliminadorCuenta : IServicioAplicacion
{
    private readonly UserManager<IdentityUser> _userManager;

    public EliminadorCuenta(UserManager<IdentityUser> userManager)
    {
        this._userManager = userManager;
    }

    public async Task Ejecutar(string id)
    {
        IdentityUser? cuenta = await this._userManager.FindByIdAsync(id).ConfigureAwait(false);

        if (cuenta != null)
        {
            IdentityResult resultado = await _userManager.DeleteAsync(cuenta);

            if (!resultado.Succeeded)
            {
                throw new Exception(resultado.Errors.ToString());
            }
        }
    }
}