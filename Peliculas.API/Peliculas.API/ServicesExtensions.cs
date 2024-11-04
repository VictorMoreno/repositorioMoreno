using Peliculas.API.Aplicacion;

namespace Peliculas.API
{
    public static class ServicesExtensions
    {
        public static IServiceCollection BindearCasosDeUso(this IServiceCollection services)
        {
            var interfaceType = typeof(IServicioAplicacion);

            var implementations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => interfaceType.IsAssignableFrom(type) && type.IsClass && !type.IsAbstract);

            foreach (var implementation in implementations)
            {
                services.AddTransient(implementation);
            }

            return services;
        }
    }
}
