using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Cuentas;
using Peliculas.API.DTOs;
using Peliculas.API.Excepciones;

namespace Peliculas.API.Controllers
{
    [Route("api/cuentas")]
    public class CuentasController : ControllerBase
    {
        [HttpPost("crear")]
        public async Task<ActionResult<RespuestaAutenticacion>> Crear([FromBody] CredencialesUsuario credenciales, [FromServices] CreadorCuenta creadorUsuario)
        {
            try
            {
                return await creadorUsuario.Ejecutar(credenciales.Email, credenciales.Password);
            }
            catch (CreacionUsuarioException error)
            {
                return BadRequest(error.Errores);
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<RespuestaAutenticacion>> Login([FromBody] CredencialesUsuario credenciales, [FromServices] LoginCuenta loginUsuario)
        {
            return await loginUsuario.Ejecutar(credenciales.Email, credenciales.Password);
        }
    }
}
