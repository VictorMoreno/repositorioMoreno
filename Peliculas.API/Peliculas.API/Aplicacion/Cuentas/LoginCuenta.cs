using Microsoft.AspNetCore.Identity;
using Peliculas.API.Aplicacion.Cuentas.Dtos;
using Peliculas.API.Dominio.Cuentas.Excepciones;
using Peliculas.API.Dominio.Cuentas.Servicios;

namespace Peliculas.API.Aplicacion.Cuentas
{
    public class LoginCuenta : IServicioAplicacion
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ConstructorToken _creadorToken;

        public LoginCuenta(SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            IConfiguration configuration)
        {
            this._signInManager = signInManager;
            this._creadorToken = new ConstructorToken(userManager, configuration);
        }

        public async Task<RespuestaAutenticacion> Ejecutar(string email, string password)
        {
            SignInResult resultado =
                await _signInManager.PasswordSignInAsync(email, password, isPersistent: false, lockoutOnFailure: false);

            if (!resultado.Succeeded)
            {
                throw new LoginIncorrectoException();
            }

            return await this._creadorToken.Generar(email);
        }
    }
}