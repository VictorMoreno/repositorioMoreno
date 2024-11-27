using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Peliculas.API.Compartido.Utilidades.DatosPrueba;

public class IdentityConfigurationExtensions
{
    public static async Task RellenarUsuarios(UserManager<IdentityUser> userManager)
    {
        await CrearUsuarioAdministrador(userManager);
        await CrearUsuarioNormal(userManager);
    }

    private static async Task CrearUsuarioNormal(UserManager<IdentityUser> userManager)
    {
        var emailUsuario = "usuario@ejemplo.com";
        var passwordUsuario = "User123*";

        if (await userManager.FindByEmailAsync(emailUsuario) == null)
        {
            var usuarioNormal = new IdentityUser
            {
                UserName = emailUsuario,
                Email = emailUsuario,
                EmailConfirmed = true
            };

            await userManager.CreateAsync(usuarioNormal, passwordUsuario);
        }
    }

    private static async Task CrearUsuarioAdministrador(UserManager<IdentityUser> userManager)
    {
        var emailAdmin = "admin@ejemplo.com";
        var passwordAdmin = "Admin123*";

        if (await userManager.FindByEmailAsync(emailAdmin) == null)
        {
            var usuarioAdmin = new IdentityUser
            {
                UserName = emailAdmin,
                Email = emailAdmin,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(usuarioAdmin, passwordAdmin);

            if (result.Succeeded)
            {
                var claim = new Claim("role", "admin");
                await userManager.AddClaimAsync(usuarioAdmin, claim);
            }
        }
    }
}