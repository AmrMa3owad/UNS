using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class DeliveryService
        : BaseService<Delivery, int>,
            IDeliveryService
    {
        public DeliveryService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}