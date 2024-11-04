namespace Peliculas.API.Entidades
{
    public partial class Actor
    {
        public void Modificar(string nombre,
            string biografia,
            DateTime fechaNacimiento,
            string foto)
        {
            this.Nombre = nombre;
            this.Biografia = biografia;
            this.FechaNacimiento = fechaNacimiento;
            this.Foto = foto;
        }
    }
}
