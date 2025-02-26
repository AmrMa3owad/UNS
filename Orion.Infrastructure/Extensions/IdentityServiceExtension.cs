using Microsoft.Extensions.DependencyInjection;
using Orion.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Orion.Context;

namespace Orion.Infrastructure.Extentions
{
    internal static class IdentityServiceExtension
    {
        internal static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequiredLength = 7;
                opt.Password.RequireDigit = true;
                opt.Password.RequireUppercase = true;
                opt.User.RequireUniqueEmail = true;
                opt.SignIn.RequireConfirmedEmail = true;
                opt.Tokens.EmailConfirmationTokenProvider = "emailconfirmation";
            })
                .AddEntityFrameworkStores<AppDbContext>()
                 .AddTokenProvider<EmailConfirmationTokenProvider<User>>
                 ("emailconfirmation");
            services.Configure<DataProtectionTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromHours(2));
            services.Configure<EmailConfirmationTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromDays(3));
        }
    }
}
