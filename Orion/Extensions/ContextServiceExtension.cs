//using Microsoft.EntityFrameworkCore;
//using Orion.Context;

//namespace Orion.Extensions
//{
//    public static class ContextServiceExtension
//    {
//        public static void ConfigureDbContext(this IServiceCollection services,
//            IConfiguration configuration)
//        {
//            var FSMConnStr = configuration["ConnectionStrings:FSM"];

//            services
//                .AddDbContext<AppDbContext>(options =>
//                {
//                    options
//                    .UseNpgsql(FSMConnStr);
//                    options
//                    .UseQueryTrackingBehavior(
//                        QueryTrackingBehavior.NoTracking);
//                });

//            services.AddScoped<IAppContext, Context.AppContext>();
//        }
//    }
//}
