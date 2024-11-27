using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Actores;
using Peliculas.API.Aplicacion.Actores.Dtos;
using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.App.Controllers
{
    [Route("api/actores")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class ActoresController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<ActorDto>>> Get([FromQuery] PaginacionDto paginacionDto,
            [FromServices] BuscadorActor buscadorActores)
        {
            return await buscadorActores.Ejecutar(paginacionDto, HttpContext);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ActorDto>> Get(int id, [FromServices] EncontradorActor encontradorActor)
        {
            return await encontradorActor.Ejecutar(id);
        }

        [HttpGet("buscarPorNombre/{nombre}")]
        public async Task<ActionResult<List<PeliculaActorDto>>> BuscarPorNombre(string nombre,
            [FromServices] BuscadorPeliculasActor buscadorPeliculasActor)
        {
            return await buscadorPeliculasActor.Ejecutar(nombre);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] ActorCreacionDto actorCreacionDto,
            [FromServices] CreadorActor creadorActor)
        {
            await creadorActor.Ejecutar(actorCreacionDto);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromForm] ActorCreacionDto actor,
            [FromServices] ModificadorActor modificadorActor)
        {
            await modificadorActor.Ejecutar(id, actor);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id, [FromServices] EliminadorActor eliminadorActores)
        {
            await eliminadorActores.Ejecutar(id);
            return NoContent();
        }
    }
}