using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Ratings;
using Peliculas.API.DTOs;

namespace Peliculas.API.Controllers;

[Route("api/rating")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class RatingController : ControllerBase
{
    [HttpPost]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult> Post([FromBody] RatingDto rating, [FromServices] CreadorRating creadorRating)
    {
        var email = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "email").Value;
        await creadorRating.Ejecutar(email, rating.PeliculaId, rating.Puntuacion);

        return NoContent();
    }
}