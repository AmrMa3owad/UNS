using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class MaterialService
        : BaseService<Material, int>,
            IMaterialService
    {
        public MaterialService(
            AppDbContext context)
            : base(context)
        {

        }

        public Task Get(object materialId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}