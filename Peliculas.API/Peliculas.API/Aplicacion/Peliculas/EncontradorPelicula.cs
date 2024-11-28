using Microsoft.AspNetCore.Identity;
using Peliculas.API.Aplicacion.Peliculas.Dtos;
using Peliculas.API.Dominio.Peliculas;
using Peliculas.API.Dominio.Ratings;

namespace Peliculas.API.Aplicacion.Peliculas
{
    public class EncontradorPelicula : IServicioAplicacion
    {
        private readonly IPeliculaRepositorio _peliculaRepositorio;
        private readonly IRatingRepositorio _ratingRepositorio;
        private readonly UserManager<IdentityUser> _userManager;

        public EncontradorPelicula(IPeliculaRepositorio peliculaRepositorio, IRatingRepositorio ratingRepositorio,
            UserManager<IdentityUser> userManager)
        {
            this._peliculaRepositorio = peliculaRepositorio;
            this._ratingRepositorio = ratingRepositorio;
            this._userManager = userManager;
        }

        public async Task<PeliculaDto> Ejecutar(int id, bool estaAutenticado, string email)
        {
            Pelicula pelicula = await this._peliculaRepositorio.ObtenerPorId(id);

            if (pelicula == null)
            {
                throw new FileNotFoundException();
            }

            (double votoPromedio, int votoUsuario) datosRating =
                await this.GestionarVoto(estaAutenticado, email, pelicula.Id);

            return pelicula.ToDto(datosRating);
        }

        private async Task<(double votoPromedio, int votoUsuario)> GestionarVoto(bool estaAutenticado,
            string email,
            int idPelicula)
        {
            var ratingVacio = (0.0, 0);

            if (!await this._ratingRepositorio.ExisteRatingPelicula(idPelicula))
            {
                return ratingVacio;
            }

            double votoPromedio = await this._ratingRepositorio.ObtenerMediaRatings(idPelicula);
            int votoUsuario = 0;

            if (estaAutenticado)
            {
                var usuario = await this._userManager.FindByEmailAsync(email);
                var idUsuario = usuario.Id;

                var ratingUsuario = await this._ratingRepositorio.ObtenerRatingUsuario(idUsuario, idPelicula);

                if (ratingUsuario != null)
                {
                    votoUsuario = ratingUsuario.Puntuacion;
                }
            }

            return (votoPromedio, votoUsuario);
        }
    }
}