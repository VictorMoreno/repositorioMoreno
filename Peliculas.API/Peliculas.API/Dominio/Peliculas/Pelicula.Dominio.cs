namespace Peliculas.API.Dominio.Peliculas
{
    public partial class Pelicula
    {
        public Pelicula()
        {
        }
        
        public Pelicula(int id,
            string titulo,
            string resumen,
            string trailer,
            bool enCines,
            DateTime fechaLanzamiento,
            string poster,
            List<PeliculasActores> peliculasActores = null,
            List<PeliculasGeneros> peliculasGeneros = null,
            List<PeliculasCines> peliculasCines = null)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Resumen = resumen;
            this.Trailer = trailer;
            this.EnCines = enCines;
            this.FechaLanzamiento = fechaLanzamiento;
            this.Poster = poster;
            this.PeliculasActores = peliculasActores;
            this.PeliculasGeneros = peliculasGeneros;
            this.PeliculasCines = peliculasCines;
        }

        public static Pelicula Crear(string titulo,
            string resumen,
            string trailer,
            bool enCines,
            DateTime fechaLanzamiento,
            string poster,
            List<PeliculasActores> peliculasActores,
            List<PeliculasGeneros> peliculasGeneros,
            List<PeliculasCines> peliculasCines)
        {
            var pelicula = new Pelicula(0,
                titulo,
                resumen,
                trailer,
                enCines,
                fechaLanzamiento,
                poster,
                peliculasActores,
                peliculasGeneros,
                peliculasCines);

            pelicula.OrdenarActores();
            return pelicula;
        }

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
            this.PeliculasActores = actores.Select(actor => new PeliculasActores
                { ActorId = actor.id, Personaje = actor.personaje }).ToList();

            this.OrdenarActores();
        }

        public void AsignarPoster(string poster)
        {
            this.Poster = poster;
        }

        private void OrdenarActores()
        {
            if (this.PeliculasActores != null)
            {
                for (int i = 0; i < this.PeliculasActores.Count; i++)
                {
                    this.PeliculasActores[i].Orden = i;
                }
            }
        }
    }
}