using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class CustomerService
        : BaseServiceUser<Customer, int>,
            ICustomerService
    {
        public CustomerService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}