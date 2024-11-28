using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Cines;
using Peliculas.API.Aplicacion.Cines.Dtos;
using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.App.Controllers
{
    [Route("api/cines")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class CinesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<CineDto>>> Get([FromQuery] PaginacionDto paginacionDto,
            [FromServices] BuscadorCinePaginado buscador)
        {
            return await buscador.Ejecutar(paginacionDto, HttpContext);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CineDto>> Get(int id, [FromServices] EncontradorCine encontrador)
        {
            return await encontrador.Ejecutar(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CineCreacionDto input, [FromServices] CreadorCine creador)
        {
            await creador.Ejecutar(input);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] CineCreacionDto input,
            [FromServices] ModificadorCine modificador)
        {
            await modificador.Ejecutar(id, input.Nombre, input.Latitud, input.Longitud);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id, [FromServices] EliminadorCine eliminadorCine)
        {
            await eliminadorCine.Ejecutar(id);
            return NoContent();
        }
    }
}