using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface IOrphanageService :
        IBaseService<Orphanage, int>
    {
        Task<Orphanage> GetIncludeAsync(int orphanageId, CancellationToken cancellationToken);
    }
}
