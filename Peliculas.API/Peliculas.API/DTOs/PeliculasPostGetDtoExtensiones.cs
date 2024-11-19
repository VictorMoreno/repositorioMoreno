namespace Peliculas.API.DTOs
{
    public static class PeliculasPostGetDtoExtensiones
    {
        public static PeliculasPostGetDto ToResponse(List<GeneroDto> generos, List<CineDto> cines)
        {
            return new PeliculasPostGetDto
            {
                Cines = cines,
                Generos = generos
            };
        }
    }
}
