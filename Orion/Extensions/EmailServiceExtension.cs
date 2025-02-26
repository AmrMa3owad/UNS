using Microsoft.AspNetCore.Identity.UI.Services;
using Orion.Handlers;

namespace Orion.Extensions
{
    public static class EmailServiceExtension
    {
        public static void ConfigureEmailSender(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(
                configuration.GetSection("Email"));
        }
    }
}
