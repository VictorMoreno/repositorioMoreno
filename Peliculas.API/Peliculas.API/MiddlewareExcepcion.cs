using Peliculas.API.Dominio;

namespace Peliculas.API;

public class MiddlewareExcepcion
{
    private readonly RequestDelegate _next;

    public MiddlewareExcepcion(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        if (exception is DomainError)
        {
            context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            return context.Response.WriteAsJsonAsync(new
            {
                status = 422,
                message = exception.Message
            });
        }

        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        return context.Response.WriteAsJsonAsync(new
        {
            status = 500,
            message = "Ocurrió un error inesperado."
        });
    }
}