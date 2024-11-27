using Peliculas.API.Compartido.Dtos;

namespace Peliculas.API.Compartido.Utilidades
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, PaginacionDto paginacionDto)
        {
            return queryable.
                Skip((paginacionDto.Pagina - 1) * paginacionDto.RegistrosPorPagina)
                .Take(paginacionDto.RegistrosPorPagina);
        }
    }
}
