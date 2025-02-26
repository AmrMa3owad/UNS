using Microsoft.EntityFrameworkCore;
using Orion.Context;
using Orion.Domain.Models.Common;

namespace Orion.Infrastructure.Common
{
    public class BaseServiceUser<T, IType> : IBaseServiceUser<T, IType> where T : BaseUser<IType>
    {
        protected readonly AppDbContext Context;

        public BaseServiceUser(AppDbContext context)
        {
            Context = context;
        }

        public async Task<T> Create(T entity)
        {
            Context.AddAsync(entity);
            if (SaveChanges())
            {
                return entity;
            }
            return null;
        }

        public async Task<bool> Update(T entity)
        {
            Context.Update(entity);
            if(SaveChanges())
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(T entity)
        {
            Context.Remove(entity);
            if (SaveChanges())
            {
                return true;
            }
            return false;
        }

        public Task<T?> Get(IType id, CancellationToken cancellationToken)
        {
            return Context.Set<T>().FirstOrDefaultAsync(x => x.UserId.Equals(id), cancellationToken);
        }

        public IQueryable<T> GetAll(CancellationToken cancellationToken)
        {
            return Context.Set<T>()
                .AsQueryable();
        }

        private bool SaveChanges()
        {
            if (Context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

    }
}
