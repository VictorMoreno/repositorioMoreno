namespace Peliculas.API.Aplicacion.Actores.Dtos
{
    public class ActorDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Foto { get; set; }
    }
}
