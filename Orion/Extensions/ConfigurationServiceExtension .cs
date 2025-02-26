using Orion.Handlers;

namespace Orion.Extensions
{
    public static class ConfigurationServiceExtension
    {
        public static void ConfigureWebApi(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            //services.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
