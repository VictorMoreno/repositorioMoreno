﻿
namespace Peliculas.API.Dominio.GestoresImagenes
{
    public interface IAlmacenadorArchivoRepositorio
    {
        Task BorrarArchivo(string ruta, string contenedor);
        Task<string> EditarArchivo(string contenedor, IFormFile archivo, string ruta);
        Task<string> GuardarArchivo(string contenedor, IFormFile archivo);
    }
}