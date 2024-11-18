using Microsoft.AspNetCore.Identity.UI.Services;
using Peliculas.API.Aplicacion;
using Peliculas.API.Repositorios;

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

        public static IServiceCollection BindearRepositorios(this IServiceCollection services)
        {
            services.AddTransient<IGeneroRepositorio, BaseDatosGeneroRepositorio>();
            services.AddTransient<IActorRepositorio, BaseDatosActorRepositorio>();
            services.AddTransient<ICineRepositorio, BaseDatosCineRepositorio>();
            services.AddTransient<IPeliculaRepositorio, BaseDatosPeliculaRepositorio>();
            services.AddTransient<IUsuarioRepositorio, BaseDatosUsuarioRepositorio>();
            services.AddTransient<IRatingRepositorio, BaseDatosRatingRepositorio>();
            services.AddTransient<IAlmacenadorArchivoRepositorio, AlmacenadorArchivoLocal>();

            return services;
        }

        public static IServiceCollection BindearFuncionalidadesExtras(this IServiceCollection services)
        {
            services.AddTransient<IProveedorContenedor, ProveedorManualContenedor>();
            services.AddSingleton<IEmailSender, SmtpEmailSender>();

            return services;
        }
    }
}