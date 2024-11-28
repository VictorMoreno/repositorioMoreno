namespace Peliculas.API.Dominio.Peliculas
{
    public partial class PeliculasCines
    {
        public static List<PeliculasCines> Crear(List<int> idsCines)
        {
            return idsCines.Select(cine => new PeliculasCines { CineId = cine }).ToList();
        }
    }
}
