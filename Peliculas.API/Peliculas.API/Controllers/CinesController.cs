﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Cines;
using Peliculas.API.DTOs;

namespace Peliculas.API.Controllers
{
    [Route("api/cines")]
    [ApiController]   
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Policy = "EsAdmin")]
    public class CinesController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<CineDto>>> Get([FromQuery] PaginacionDto paginacionDto, [FromServices] BuscadorCinePaginado buscador)
        {
            return await buscador.Ejecutar(paginacionDto, HttpContext);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CineDto>> Get(int id, [FromServices]EncontradorCine encontrador)
        {
            return await encontrador.Ejecutar(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CineCreacionDTO input, [FromServices] CreadorCine creador)
        {
            await creador.Ejecutar(input);
            return NoContent();
        }

        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(int id, [FromBody] GeneroCreacionDto genero)
        //{
        //    await this._repositorio.Actualizar(id, genero.Nombre);
        //    return NoContent();
        //}

        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    await this._repositorio.Eliminar(id);
        //    return NoContent();
        //}
    }
}
