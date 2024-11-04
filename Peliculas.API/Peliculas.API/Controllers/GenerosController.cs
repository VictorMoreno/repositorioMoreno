using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Generos;
using Peliculas.API.DTOs;
using Peliculas.API.Repositorios;

namespace Peliculas.API.Controllers
{
    [Route("api/generos")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Policy = "EsAdmin")]
    public class GenerosController : ControllerBase
    {
        private readonly IGeneroRepositorio _repositorio;

        public GenerosController(IGeneroRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<GeneroDto>>> Get([FromQuery] PaginacionDto paginacionDto, [FromServices] BuscadorGeneroPaginado buscador)
        {
            return await buscador.Ejecutar(paginacionDto, HttpContext);
        }

        [HttpGet("todos")]
        [AllowAnonymous]
        public async Task<ActionResult<List<GeneroDto>>> GetAll([FromServices] BuscadorGenero buscador)
        {
            return await buscador.Ejecutar();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GeneroDto>> Get(int id, [FromServices] EncontradorGenero encontrador)
        {
            return await encontrador.Ejecutar(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GeneroCreacionDto genero, [FromServices] CreadorGenero generador)
        {
            await generador.Ejecutar(genero);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] GeneroCreacionDto genero, [FromServices] ModificadorGenero modificador)
        {
            await modificador.Ejecutar(id, genero);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id, [FromServices] EliminadorGenero eliminador)
        {
            await eliminador.Ejecutar(id);
            return NoContent();
        }
    }
}
