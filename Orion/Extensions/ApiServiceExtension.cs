using Asp.Versioning;
using Orion.Handlers;

namespace Orion.Extensions
{
    public static class ApiServiceExtension
    {
        public static void ConfigureHttpContext(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IClaimHandler, ClaimHandler>();
        }
        public static void ConfigureApiVersions(this IServiceCollection services)
        {
            services.AddApiVersioning(o=> {
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
                o.ReportApiVersions = true;
            })
            .AddApiExplorer(o =>
            {
                o.GroupNameFormat = "'v'VVV";
                o.SubstituteApiVersionInUrl = true;
            });
        }
    }
}
