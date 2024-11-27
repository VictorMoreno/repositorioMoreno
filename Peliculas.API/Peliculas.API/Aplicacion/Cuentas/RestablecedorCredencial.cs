using Microsoft.AspNetCore.Identity;
using Peliculas.API.Dominio.Cuentas.Excepciones;

namespace Peliculas.API.Aplicacion.Cuentas;

public class RestablecedorCredencial : IServicioAplicacion
{
    private readonly UserManager<IdentityUser> _userManager;

    public RestablecedorCredencial(UserManager<IdentityUser> userManager)
    {
        this._userManager = userManager;
    }

    public async Task Ejecutar(string email, string token, string nuevaPassword)
    {
        var usuario = await _userManager.FindByEmailAsync(email);
        
        if (usuario != null)
        {
            var resultado = await _userManager.ResetPasswordAsync(usuario, token, nuevaPassword);

            if (!resultado.Succeeded)
            {
                throw new EstablecerPasswordException();
            }
        }
    }
}