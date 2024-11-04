using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Cuentas;
using Peliculas.API.DTOs;
using Peliculas.API.Excepciones;

namespace Peliculas.API.Controllers
{
    [Route("api/cuentas")]
    public class CuentasController : ControllerBase
    {
        [HttpGet("listadoUsuarios")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Policy = "EsAdmin")]
        public async Task<ActionResult<List<UsuarioDto>>> ListadoUsuarios([FromQuery] PaginacionDto paginacion,
            [FromServices] BuscadorCuentaPaginado buscador)
        {
            return await buscador.Ejecutar(paginacion, HttpContext);
        }

        [HttpPost("HacerAdmin")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Policy = "EsAdmin")]
        public async Task<ActionResult> HacerAdmin([FromBody] string idUsuario,
            [FromServices] AsignadorRolAdmin asignadorRolAdmin)
        {
            await asignadorRolAdmin.Ejecutar(idUsuario);
            return NoContent();
        }

        [HttpPost("QuitarAdmin")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Policy = "EsAdmin")]
        public async Task<ActionResult> QuitarAdmin([FromBody] string idUsuario,
            [FromServices] EliminadorRolAdmin eliminadorRolAdmin)
        {
            await eliminadorRolAdmin.Ejecutar(idUsuario);
            return NoContent();
        }

        [HttpPost("crear")]
        public async Task<ActionResult<RespuestaAutenticacion>> Crear([FromBody] CredencialesUsuario credenciales,
            [FromServices] CreadorCuenta creadorUsuario)
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
        public async Task<ActionResult<RespuestaAutenticacion>> Login([FromBody] CredencialesUsuario credenciales,
            [FromServices] LoginCuenta loginUsuario)
        {
            return await loginUsuario.Ejecutar(credenciales.Email, credenciales.Password);
        }
    }
}