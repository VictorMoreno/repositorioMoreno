using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Cuentas;
using Peliculas.API.Aplicacion.Cuentas.Dtos;
using Peliculas.API.App.Dtos;
using Peliculas.API.Compartido.Dtos;
using Peliculas.API.Dominio.Cuentas.Excepciones;

namespace Peliculas.API.App.Controllers
{
    [Route("api/cuentas")]
    [ApiController]
    public class CuentasController : ControllerBase
    {
        [HttpGet("listadoUsuarios")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
        public async Task<ActionResult<List<UsuarioDto>>> ListadoUsuarios([FromQuery] PaginacionDto paginacion,
            [FromServices] BuscadorCuentaPaginado buscador)
        {
            return await buscador.Ejecutar(paginacion, HttpContext);
        }

        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
        public async Task<ActionResult<UsuarioDto>> ObtenerUsuario(string id, [FromServices] ObtenedorCuenta obtenedor)
        {
            return await obtenedor.Ejecutar(id);
        }

        [HttpPost("hacerAdmin")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
        public async Task<ActionResult> HacerAdmin([FromBody] string idUsuario,
            [FromServices] AsignadorRolAdmin asignadorRolAdmin)
        {
            await asignadorRolAdmin.Ejecutar(idUsuario);
            return NoContent();
        }

        [HttpPost("quitarAdmin")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
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
            return await creadorUsuario.Ejecutar(credenciales.Email, credenciales.Password);
        }

        [HttpPost("login")]
        public async Task<ActionResult<RespuestaAutenticacion>> Login([FromBody] CredencialesUsuario credenciales,
            [FromServices] LoginCuenta loginUsuario)
        {
            return await loginUsuario.Ejecutar(credenciales.Email, credenciales.Password);
        }

        [HttpPost("solicitarRestablecimiento")]
        public async Task<ActionResult> Login([FromBody] SolicitudRestablecerCredencial credencial,
            [FromServices] SolicitadorRestablecerCredencial solicitadorRestablecerCredencial)
        {
            await solicitadorRestablecerCredencial.Ejecutar(credencial.Email);
            return NoContent();
        }

        [HttpPost("restablecer")]
        [AllowAnonymous]
        public async Task<ActionResult> Login([FromBody] RestablecerCredencial credencial,
            [FromServices] RestablecedorCredencial restablecedorCredencial)
        {
            await restablecedorCredencial.Ejecutar(credencial.Email, credencial.Token, credencial.Password);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
        public async Task<ActionResult> Delete(string id,
            [FromServices] EliminadorCuenta eliminadorCuenta)
        {
            await eliminadorCuenta.Ejecutar(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody] UsuarioEdicionDto usuario,
            [FromServices] ModificadorCuenta modificador)
        {
            await modificador.Ejecutar(id, usuario.Email);
            return NoContent();
        }
    }
}