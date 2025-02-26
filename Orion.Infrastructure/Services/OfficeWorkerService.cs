using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public class OfficeWorkerService
        : BaseServiceEmployee<OfficeWorker, int>,
            IOfficeWorkerService
    {
        public OfficeWorkerService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}