namespace Peliculas.API.Dominio.Actores
{
    public partial class Actor
    {
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
