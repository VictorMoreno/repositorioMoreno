namespace Peliculas.API.Entidades
{
    public partial class Pelicula
    {
        public void Modificar(string titulo,
            string resumen,
            string trailer,
            bool enCines,
            DateTime fechaLanzamiento,
            string poster,
            List<int> idsGeneros,
            List<int> idsCines,
            List<(int id, string personaje)> actores)
        {
            this.Titulo = titulo;
            this.Resumen = resumen;
            this.Trailer = trailer;
            this.EnCines = enCines;
            this.FechaLanzamiento = fechaLanzamiento;
            this.Poster = poster;
            this.PeliculasGeneros = idsGeneros.Select(genero => new PeliculasGeneros { GeneroId = genero }).ToList();
            this.PeliculasCines = idsCines.Select(cine => new PeliculasCines { CineId = cine }).ToList();
            this.PeliculasActores = actores.Select(actor => new PeliculasActores { ActorId = actor.id, Personaje = actor.personaje }).ToList();
        }
    }
}
