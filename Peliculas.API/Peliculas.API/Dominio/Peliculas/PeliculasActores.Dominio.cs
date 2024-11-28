namespace Peliculas.API.Dominio.Peliculas
{
    public partial class PeliculasActores
    {
        public static PeliculasActores Crear(int idActor, string personaje)
        {
            return new PeliculasActores
            {
                ActorId = idActor,
                Personaje = personaje
            };
        }
    }
}