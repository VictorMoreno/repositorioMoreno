namespace Peliculas.API.Dominio.Peliculas
{
    public partial class PeliculasGeneros
    {
        public static List<PeliculasGeneros> Crear(List<int> idsGeneros)
        {
            return idsGeneros.Select(genero => new PeliculasGeneros { GeneroId = genero }).ToList();
        }
    }
}