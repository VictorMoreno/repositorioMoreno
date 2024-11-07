using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Cines;
using Peliculas.API.Aplicacion.Generos;
using Peliculas.API.Aplicacion.Peliculas;
using Peliculas.API.DTOs;

namespace Peliculas.API.Controllers
{
    [Route("api/peliculas")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class PeliculasController : ControllerBase
    {
        // TODO: Comprobar que se puede borrar
        // [HttpGet]
        // public async Task<ActionResult<List<ActorDto>>> Get([FromQuery] PaginacionDto paginacionDto, [FromServices] BuscadorActor buscadorActores)
        // {
        //     return await buscadorActores.Ejecutar(paginacionDto, HttpContext);
        // }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PeliculaDTO>> Get(int id, [FromServices] EncontradorPelicula encontradorPelicula)
        {
            return await encontradorPelicula.Ejecutar(id);
        }

        [HttpGet("filtrar")]
        [AllowAnonymous]
        public async Task<ActionResult<List<PeliculaDTO>>> Filtrar([FromQuery] PeliculasFiltrarDto peliculasFiltrarDto,
            [FromServices] BuscadorPeliculas buscadorPeliculas)
        {
            return await buscadorPeliculas.Ejecutar(HttpContext,
                peliculasFiltrarDto.PaginacionDto,
                peliculasFiltrarDto.Titulo,
                peliculasFiltrarDto.EnCines,
                peliculasFiltrarDto.GeneroId,
                peliculasFiltrarDto.ProximosEstrenos);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] PeliculaCreacionDTO pelicula,
            [FromServices] CreadorPelicula creadorPelicula)
        {
            await creadorPelicula.Ejecutar(pelicula);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromForm] PeliculaCreacionDTO pelicula,
            [FromServices] ModificadorPelicula modificadorPelicula)
        {
            await modificadorPelicula.Ejecutar(id, pelicula);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id, [FromServices] EliminadorPelicula eliminadorPeliculla)
        {
            await eliminadorPeliculla.Ejecutar(id);
            return NoContent();
        }

        [HttpGet("PostGet")]
        public async Task<ActionResult<PeliculasPostGetDTO>> PostGet([FromServices] BuscadorCine buscadorCine,
            BuscadorGenero buscadorGenero)
        {
            var generos = await buscadorGenero.Ejecutar();
            var cines = await buscadorCine.Ejecutar();

            return PeliculasPostGetDtoExtensiones.ToResponse(generos, cines);
        }

        [HttpGet("PutGet/{id:int}")]
        public async Task<ActionResult<PeliculasPutGetDto>> PutGet(int id,
            [FromServices] BuscadorPeliculaParaEdicion buscadorPeliculaParaEdicion)
        {
            return await buscadorPeliculaParaEdicion.Ejecutar(id);
        }


        [HttpGet("landingFilms")]
        [AllowAnonymous]
        public async Task<ActionResult<LandingPageDto>> GetLandingFilms(
            [FromServices] BuscadorPeliculasPortada buscadorPeliculasPortada)
        {
            return await buscadorPeliculasPortada.Ejecutar();
        }
    }
}