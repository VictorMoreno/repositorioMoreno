using Microsoft.AspNetCore.Mvc.Filters;

namespace Peliculas.API.Filtros
{
    public class FiltroExcepcion : ExceptionFilterAttribute
    {
        private readonly ILogger<FiltroExcepcion> logger;

        public FiltroExcepcion(ILogger<FiltroExcepcion> logger)
        {
            this.logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            this.logger.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }
    }
}
