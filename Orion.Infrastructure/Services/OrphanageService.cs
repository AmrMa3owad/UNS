using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Orion.Infrastructure.Services
{
    public class OrphanageService
        : BaseService<Orphanage, int>,
            IOrphanageService
    {
        private readonly AppDbContext _context;

        public OrphanageService(
            AppDbContext context)
            : base(context)
        {
            _context = context;
        }
        public async Task<Orphanage> GetIncludeAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Orphanages
                .Include(f => f.Freelancers)
                .ThenInclude(f => f.Products)
                .Include(f => f.SupervisorOrphanages)
                .ThenInclude(f => f.Supervisor)              
                .FirstOrDefaultAsync(f => f.Id == id, cancellationToken);
        }
        public async Task<List<Orphanage>> GetAllInclude(CancellationToken cancellationToken)
        {
            return await _context.Orphanages
                .Include(f => f.Freelancers)
                .ThenInclude(f => f.Products)
                .Include(f => f.SupervisorOrphanages)
                .ThenInclude(f => f.Supervisor)
                .ToListAsync(cancellationToken);
        }
    }
}