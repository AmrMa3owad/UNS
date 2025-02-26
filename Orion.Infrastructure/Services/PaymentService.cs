using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public class PaymentService
        : BaseService<Payment, int>,
            IPaymentService
    {
        public PaymentService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}