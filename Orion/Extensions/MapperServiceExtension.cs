using AutoMapper;
using Orion.Common;

namespace Orion.Extensions
{
    internal static class MapperServiceExtension
    {
        internal static void ConfigureMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(
                mc =>
            {
                mc.AddProfile(new ApiMappingProfile());
                //mc.AddProfile(new ApplicationMappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
