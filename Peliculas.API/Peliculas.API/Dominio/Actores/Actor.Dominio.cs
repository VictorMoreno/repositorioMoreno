namespace Peliculas.API.Dominio.Actores
{
    public partial class Actor
    {
        public Actor(int id, string nombre, string biografia, DateTime fechaNacimiento, string foto)
        {
            Id = id;
            Nombre = nombre;
            Biografia = biografia;
            FechaNacimiento = fechaNacimiento;
            Foto = foto;
        }

        public static Actor Crear(string nombre, string biografia, DateTime fechaNacimiento) =>
            new(0, nombre, biografia, fechaNacimiento, string.Empty);

        public void Modificar(string nombre,
            string? biografia,
            DateTime fechaNacimiento,
            string foto)
        {
            this.Nombre = nombre;
            this.Biografia = string.IsNullOrEmpty(biografia) ? string.Empty : biografia;
            this.FechaNacimiento = fechaNacimiento;
            this.Foto = foto;
        }
    }
}