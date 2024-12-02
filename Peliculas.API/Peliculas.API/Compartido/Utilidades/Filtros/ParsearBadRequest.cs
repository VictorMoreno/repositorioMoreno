using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Peliculas.API.Dominio;

namespace Peliculas.API.Compartido.Utilidades.Filtros
{
    public class ParsearBadRequest : IActionFilter
    {
        private const int ERROR_400 = 400;
        private const int OK_200 = 200;

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var casteoResult = context.Result as IStatusCodeActionResult;

            if (casteoResult == null || (casteoResult.StatusCode == OK_200))
            {
                return;
            }

            var codigoStatus = casteoResult.StatusCode;

            var respuesta = new List<string>();
            var resultadoActual = context.Result as BadRequestObjectResult;

            if (resultadoActual.Value is string)
            {
                respuesta.Add(resultadoActual.Value.ToString());
            }
            else if (resultadoActual.Value is IEnumerable<IdentityError> errores)
            {
                foreach (var error in errores)
                {
                    respuesta.Add(error.Description);
                }
            }
            else
            {
                foreach (var llave in context.ModelState.Keys)
                {
                    foreach (var error in context.ModelState[llave].Errors)
                    {
                        respuesta.Add($"{llave}: {error.ErrorMessage}");
                    }
                }
            }

            if (codigoStatus == ERROR_400 && context.Exception != null && context.Exception is not DomainError)
            {
                context.Result = new BadRequestObjectResult(respuesta);
            }
            else if (context.Exception is DomainError exception)
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
                context.HttpContext.Response.ContentType = "application/json";

                var responseContent = new
                {
                    status = 422,
                    message = exception.Message
                };

                context.Result = new JsonResult(responseContent);
                context.ExceptionHandled = true;
            }
            else if (context.Exception != null)
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.HttpContext.Response.ContentType = "application/json";

                var responseContent = new
                {
                    status = 500,
                    message = "Ocurrió un error inesperado."
                };

                context.Result = new JsonResult(responseContent);
                context.ExceptionHandled = true;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}