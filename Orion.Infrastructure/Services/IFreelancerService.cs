using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface IFreelancerService :
        IBaseServiceUser<Freelancer, int>
    {
        Task<List<Freelancer>> GetAllInclude(CancellationToken cancellationToken);
        Task<Freelancer> GetFreelancerWithOrphanageAsync(int id, CancellationToken cancellationToken);
    }
}
