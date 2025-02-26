using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Orion.Handlers;

namespace Orion.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureWebApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<IClaimHandler, ClaimHandler>();

            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(configuration["WebApi:Url"])
            };
            services.AddSingleton(httpClient);
        }

        public static void ConfigureRouter(this IServiceCollection services)
        {
            services.AddMvc()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AddPageRoute("/EndUser/Home", "Index.html");
                    options.Conventions.AddPageRoute("/EndUser/main-products", "main-products.html");
                    options.Conventions.AddPageRoute("/EndUser/raw", "raw.html");
                    options.Conventions.AddPageRoute("/EndUser/Sign", "Sign.html");
                    options.Conventions.AddPageRoute("/EndUser/orionForm", "orionForm.html");
                    options.Conventions.AddPageRoute("/EndUser/details", "details.html");
                    options.Conventions.AddPageRoute("/EndUser/visa", "visa.html");
                    options.Conventions.AddPageRoute("/EndUser/checkout", "checkout.html");
                    options.Conventions.AddPageRoute("/EndUser/childProfile", "childProfile.html");
                    options.Conventions.AddPageRoute("/EndUser/donate", "donate.html");
                    options.Conventions.AddPageRoute("/EndUser/feedback", "feedback.html");
                    options.Conventions.AddPageRoute("/EndUser/orphanage", "orphanage.html");
                    options.Conventions.AddPageRoute("/EndUser/Home", "Home.html");


                    options.Conventions.AddPageRoute("/Supervisor/AddProduct", "AddProduct.html");
                    options.Conventions.AddPageRoute("/Supervisor/childsProfile", "childsProfile.html");
                    options.Conventions.AddPageRoute("/Supervisor/editPro", "editPro.html");
                    options.Conventions.AddPageRoute("/Supervisor/editProFreelancer", "editProFreelancer.html");
                    options.Conventions.AddPageRoute("/Supervisor/superProfile", "superProfile.html");
                    options.Conventions.AddPageRoute("/Supervisor/superSignIn", "superSignIn.html");
                    options.Conventions.AddPageRoute("/Supervisor/superSignup", "superSignup.html");


                    options.Conventions.AddPageRoute("/Admin/AddAdmin", "AddAdmin.html");
                    options.Conventions.AddPageRoute("/Admin/addCategory", "addCategory.html");
                    options.Conventions.AddPageRoute("/Admin/addMaterial", "addMaterial.html");
                    options.Conventions.AddPageRoute("/Admin/AddOrphanage", "AddOrphanage.html");
                    options.Conventions.AddPageRoute("/Admin/AddSuper", "AddSuper.html");

                    options.Conventions.AddPageRoute("/Admin/adminMaterial", "adminMaterial.html");
                    options.Conventions.AddPageRoute("/Admin/adminSignIn", "adminSignIn.html");
                    options.Conventions.AddPageRoute("/Admin/childProfileAdmin", "childProfileAdmin.html");
                    options.Conventions.AddPageRoute("/Admin/childstable", "childstable.html");
                    options.Conventions.AddPageRoute("/Admin/ContactUs", "ContactUs.html");
                    options.Conventions.AddPageRoute("/Admin/Dashboard", "Dashboard.html");
                    options.Conventions.AddPageRoute("/Admin/detailsAdmin", "detailsAdmin.html");
                    options.Conventions.AddPageRoute("/Admin/EditMaterial", "EditMaterial.html");
                    options.Conventions.AddPageRoute("/Admin/editOrphanage", "editOrphanage.html");
                    options.Conventions.AddPageRoute("/Admin/email", "email.html");
                    options.Conventions.AddPageRoute("/Admin/orphanageAdmin", "orphanageAdmin.html");
                    options.Conventions.AddPageRoute("/Admin/orphanageSSS", "orphanageSSS.html");
                    options.Conventions.AddPageRoute("/Admin/superProfileAdmin", "superProfileAdmin.html");
                    options.Conventions.AddPageRoute("/Admin/supertable", "supertable.html");
                    options.Conventions.AddPageRoute("/Admin/verify", "verify.html");
                });
        }
        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.IncludeErrorDetails = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"]
                };
            });
        }
    }
}
