using Microsoft.AspNetCore.Identity;
using Peliculas.API.Dominio.Cuentas.Servicios;
using Peliculas.API.DTOs;
using Peliculas.API.Excepciones;

namespace Peliculas.API.Aplicacion.Cuentas
{
    public class CreadorCuenta : IServicioAplicacion
    {
        private readonly UserManager<IdentityUser> _userManager;
        private ConstructorToken _creadorToken;

        public CreadorCuenta(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            this._userManager = userManager;
            this._creadorToken = new ConstructorToken(userManager, configuration);
        }

        public async Task<RespuestaAutenticacion> Ejecutar(string email, string password)
        {
            IdentityUser usuario = new IdentityUser
            {
                UserName = email,
                Email = email
            };

            IdentityResult resultado = await this._userManager.CreateAsync(usuario, password);

            if (!resultado.Succeeded)
            {
                throw new CreacionUsuarioException(resultado.Errors);
            }

            return await this._creadorToken.Generar(email);
        }    
    }
}
