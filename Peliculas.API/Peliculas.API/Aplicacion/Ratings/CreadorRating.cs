using Microsoft.AspNetCore.Identity;
using Peliculas.API.Dominio.Ratings;

namespace Peliculas.API.Aplicacion.Ratings;

public class CreadorRating : IServicioAplicacion
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IRatingRepositorio _repositorio;

    public CreadorRating(UserManager<IdentityUser> userManager, IRatingRepositorio repositorio)
    {
        this._userManager = userManager;
        this._repositorio = repositorio;
    }

    public async Task Ejecutar(string email, int idPelicula, int puntuacion)
    {
        var usuario = await _userManager.FindByEmailAsync(email);
        var idUsuario = usuario.Id;

        var ratingActual = await this._repositorio.ObtenerRatingUsuario(idUsuario, idPelicula);
        
        if (ratingActual == null)
        {
            Rating nuevoRating = Rating.Crear(puntuacion, idPelicula, idUsuario);
            await this._repositorio.Guardar(nuevoRating);
        }
        else
        {
            ratingActual.Modificar(puntuacion);
            await this._repositorio.Actualizar(ratingActual);
        }
    }
}