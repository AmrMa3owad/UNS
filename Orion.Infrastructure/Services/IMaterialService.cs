using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface IMaterialService :
        IBaseService<Material, int>
    {
        Task Get(object materialId, CancellationToken cancellationToken);
    }
}
