using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Peliculas.API.Aplicacion.Cuentas;

public class SolicitadorRestablecerCredencial : IServicioAplicacion
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IEmailSender _emailSender;
    private readonly string _cuerpoMensaje = "$\"<a href='{0}'>Restablecer Contraseña</a>\"";

    public SolicitadorRestablecerCredencial(UserManager<IdentityUser> userManager, IEmailSender emailSender)
    {
        this._userManager = userManager;
        this._emailSender = emailSender;
    }

    public async Task Ejecutar(string email)
    {
        var usuario = await this._userManager.FindByEmailAsync(email);

        if (usuario != null)
        {
            string tokenRestablecer = await this._userManager.GeneratePasswordResetTokenAsync(usuario);

            await _emailSender.SendEmailAsync(usuario.Email, "Restablecer contraseña",
                string.Format(this._cuerpoMensaje, tokenRestablecer)).ConfigureAwait(false);
        }
    }
}