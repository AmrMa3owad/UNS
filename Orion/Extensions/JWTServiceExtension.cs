using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Doablelink.FSM.WebApi.Extensions
{
    public static class JWTServiceExtension
    {
        //public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddAuthentication(options =>
        //    {
        //        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        //        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //    })
        //        .AddJwtBearer(options =>
        //        {

        //            options.IncludeErrorDetails = true;

        //            options.TokenValidationParameters = new TokenValidationParameters
        //            {
        //                ValidateIssuerSigningKey = true,
        //                ValidateIssuer = true,
        //                ValidateAudience = true,
        //                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
        //                ValidIssuer = configuration["Jwt:Issuer"],
        //                ValidAudience = configuration["Jwt:Audience"]
        //            };
        //        });
        //}
    }
}
