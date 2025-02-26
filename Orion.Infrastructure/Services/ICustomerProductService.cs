using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface ICustomerProductService :
        IBaseService<CustomerProduct, int>
    {
    }
}
