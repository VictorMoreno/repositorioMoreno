
namespace Peliculas.API.Repositorios
{
    public class AlmacenadorArchivoLocal : IAlmacenadorArchivoRepositorio
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AlmacenadorArchivoLocal(IWebHostEnvironment environment, IHttpContextAccessor httpContextAccessor)
        {
            this._environment = environment;
            this._httpContextAccessor = httpContextAccessor;
        }

        public Task BorrarArchivo(string ruta, string contenedor)
        {
            if (string.IsNullOrEmpty(ruta))
            {
                return Task.CompletedTask;
            }

            var nombreArchivo = Path.GetFileName(ruta);
            var directorioArchivo = Path.Combine(this._environment.WebRootPath, contenedor, nombreArchivo);

            if (!File.Exists(directorioArchivo))
            {
                File.Delete(directorioArchivo);
            }

            return Task.CompletedTask;
        }

        public async Task<string> EditarArchivo(string contenedor, IFormFile archivo, string ruta)
        {
            await this.BorrarArchivo(ruta, contenedor);
            return await this.GuardarArchivo(contenedor, archivo);
        }

        public async Task<string> GuardarArchivo(string contenedor, IFormFile archivo)
        {
            var extension = Path.GetExtension(archivo.FileName);
            var nombreArchivo = $"{Guid.NewGuid()}{extension}";
            string folder = Path.Combine(this._environment.WebRootPath, contenedor);

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string ruta = Path.Combine(folder, nombreArchivo);
            using (var memoryStream = new MemoryStream())
            {
                await archivo.CopyToAsync(memoryStream);
                var contenido = memoryStream.ToArray();
                await File.WriteAllBytesAsync(ruta, contenido);
            }

            var urlActual = $"{this._httpContextAccessor.HttpContext.Request.Scheme}://{this._httpContextAccessor.HttpContext.Request.Host}";
            var rutaAlmacenar = Path.Combine(urlActual, contenedor, nombreArchivo).Replace("\\", "/");

            return rutaAlmacenar;
        }
    }
}
