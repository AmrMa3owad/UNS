using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class AdvertisementService
        : BaseService<Advertisement, int>,
            IAdvertisementService
    {
        public AdvertisementService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}