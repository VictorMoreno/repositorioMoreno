namespace Peliculas.API.Utilidades
{
    public static class HttpContextExtensions
    {
        public async static Task InsertarParametrosPaginacionEnCabecera(this HttpContext httpContext, int cantidadTotal)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }

            httpContext.Response.Headers.Add("cantidadtotalregistros", cantidadTotal.ToString());
        }
    }
}
