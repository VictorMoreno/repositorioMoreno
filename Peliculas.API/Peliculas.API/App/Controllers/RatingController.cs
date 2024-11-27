using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peliculas.API.Aplicacion.Ratings;
using Peliculas.API.App.Dtos;

namespace Peliculas.API.App.Controllers;

[Route("api/rating")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class RatingController : ControllerBase
{
    [HttpPost]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public async Task<ActionResult> Post([FromBody] RatingDto rating, [FromServices] CreadorRating creadorRating)
    {
        var email = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email).Value;
        await creadorRating.Ejecutar(email, rating.IdPelicula, rating.Puntuacion);

        return NoContent();
    }
}