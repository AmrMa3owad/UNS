using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class BoothService
        : BaseService<Booth, int>,
            IBoothService
    {
        public BoothService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}