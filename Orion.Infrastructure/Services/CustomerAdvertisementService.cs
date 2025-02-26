using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class CustomerAdvertisementService
        : BaseService<CustomerAdvertisement, int>,
            ICustomerAdvertisementService
    {
        public CustomerAdvertisementService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}