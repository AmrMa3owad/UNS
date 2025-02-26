using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public class VendorService
        : BaseService<Vendor, int>,
            IVendorService
    {
        public VendorService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}