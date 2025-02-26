using Microsoft.Extensions.DependencyInjection;

namespace Orion.Application.Common
{
    public static class ApplicationServiceExtension
    {
        public static void ConfigureApplication(this IServiceCollection services)
        {
            services.ConfigureIdentity();

            //services.ConfigureInfrastructure();
            //services.AddScoped<IUserApplicationService, UserApplicationService>();
            //services.AddScoped<IOrganizationApplicationService, OrganizationApplicationService>();
            //services.AddScoped<IUserRoleApplicationService, UserRoleApplicationService>();
            //services.AddScoped<IRoleApplicationService, RoleApplicationService>();
        }
    }
}
