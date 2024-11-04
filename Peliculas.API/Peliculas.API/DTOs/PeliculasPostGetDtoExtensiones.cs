namespace Peliculas.API.DTOs
{
    public static class PeliculasPostGetDtoExtensiones
    {
        public static PeliculasPostGetDTO ToResponse(List<GeneroDto> generos, List<CineDto> cines)
        {
            return new PeliculasPostGetDTO
            {
                Cines = cines,
                Generos = generos
            };
        }
    }
}
