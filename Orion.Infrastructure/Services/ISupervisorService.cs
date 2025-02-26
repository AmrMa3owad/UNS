using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface ISupervisorService :
        IBaseServiceEmployee<Supervisor, int>
    {
        Task<Supervisor> GetSupervisorAsync(int id, CancellationToken cancellationToken);
        Task<List<Supervisor>> GetAllInclude(CancellationToken cancellationToken);

    }
}
