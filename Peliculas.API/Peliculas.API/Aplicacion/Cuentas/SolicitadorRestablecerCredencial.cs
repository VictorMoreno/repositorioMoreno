using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Peliculas.API.Aplicacion.Cuentas;

public class SolicitadorRestablecerCredencial : IServicioAplicacion
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IEmailSender _emailSender;
    private readonly IConfiguration _configuration;
    private readonly string _cuerpoMensaje = "$\"<a href='{0}'>Restablecer Contraseña</a>\"";

    public SolicitadorRestablecerCredencial(UserManager<IdentityUser> userManager, IEmailSender emailSender,
        IConfiguration configuration)
    {
        this._userManager = userManager;
        this._emailSender = emailSender;
        this._configuration = configuration;
    }

    public async Task Ejecutar(string email)
    {
        var usuario = await this._userManager.FindByEmailAsync(email);

        if (usuario != null)
        {
            string token = await this._userManager.GeneratePasswordResetTokenAsync(usuario);
            string urlWeb = this._configuration["FrontendUrl"]!;

            var urlRestablecimiento = $"{urlWeb}/api/restablecer?email={email}&token={token}";
            await _emailSender.SendEmailAsync(usuario.Email, "Restablecer contraseña",
                $"Haz clic en el enlace para restablecer tu contraseña: <a href='{urlRestablecimiento}'>Restablecer Contraseña</a>");
        }
    }
}