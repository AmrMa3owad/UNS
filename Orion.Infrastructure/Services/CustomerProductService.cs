using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class CustomerProductService
        : BaseService<CustomerProduct, int>,
            ICustomerProductService
    {
        public CustomerProductService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}