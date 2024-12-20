﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Cines;
using Peliculas.API.Aplicacion.Generos;
using Peliculas.API.Aplicacion.Peliculas;
using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.App.Dtos;

namespace Peliculas.API.App.Controllers
{
    [Route("api/peliculas")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class PeliculasController : ControllerBase
    {
        [HttpGet("landingFilms")]
        [AllowAnonymous]
        public async Task<ActionResult<LandingPageDto>> GetLandingFilms(
            [FromServices] BuscadorPeliculasPortada buscadorPeliculasPortada)
        {
            return await buscadorPeliculasPortada.Ejecutar();
        }

        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<ActionResult<PeliculaDto>> Get(int id, [FromServices] EncontradorPelicula encontradorPelicula)
        {
            var email = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
            return await encontradorPelicula.Ejecutar(id, HttpContext.User.Identity.IsAuthenticated, email);
        }

        [HttpGet("filtrar")]
        [AllowAnonymous]
        public async Task<ActionResult<List<PeliculaDto>>> Filtrar([FromQuery] PeliculasFiltrarDto peliculasFiltrarDto,
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
        public async Task<ActionResult> Post([FromForm] PeliculaCreacionDto pelicula,
            [FromServices] CreadorPelicula creadorPelicula)
        {
            await creadorPelicula.Ejecutar(pelicula.Titulo, pelicula.Resumen, pelicula.Trailer, pelicula.EnCines,
                pelicula.FechaLanzamiento, pelicula.Poster, pelicula.GenerosIds, pelicula.CinesIds, pelicula.Actores);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromForm] PeliculaCreacionDto pelicula,
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
        public async Task<ActionResult<PeliculasPostGetDto>> PostGet([FromServices] BuscadorCine buscadorCine,
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
    }
}