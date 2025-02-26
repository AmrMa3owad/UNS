using Microsoft.EntityFrameworkCore;
using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class CartService
        : BaseService<Cart, int>,
            ICartService
    {
        private readonly AppDbContext _context;

        public CartService(
            AppDbContext context)
            : base(context)
        {
            _context = context;
        }
        public async Task<Cart> GetCartIncludeAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Carts
                .Include(f => f.Products)
                .FirstOrDefaultAsync(f => f.Id == id, cancellationToken);
        }
        public async Task<List<Cart>> GetAllInclude(CancellationToken cancellationToken)
        {
            return await _context.Carts
                .Include(f => f.Products)
                .ToListAsync(cancellationToken);
        }
    }
}