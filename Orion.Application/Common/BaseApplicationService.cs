using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models.Common;
using Orion.Infrastructure.Common;
using Orion.Shared.Exceptions;
using System.Linq.Expressions;

namespace Orion.Application.Common
{
    public class BaseApplicationService<DTO, T, IType> 
        : IBaseApplicationService<DTO, IType> 
        where DTO : BaseEntityDTO<IType>
        where T : BaseEntity<IType>
    {
        internal readonly IMapper Mapper;
        private readonly Func<IQueryable<T>, IQueryable<T>> Include;
        private readonly Func<DTO, T, T> MapDtoToEntity;
        IBaseService<T, IType> BaseService;
        public BaseApplicationService(
            IBaseService<T,IType> baseService,
            IMapper mapper,
            Func<IQueryable<T>, IQueryable<T>> include = null,
            Func<DTO, T, T> mapDtoToEntity = null) {
            BaseService = baseService;
            Mapper = mapper;
            Include = include;
            MapDtoToEntity = mapDtoToEntity;
        }
        public async Task<DTO> Create(DTO entity)
        {
            T t = Mapper.Map<T>(entity);

            t =
                await BaseService.Create(t);
            return Mapper.Map<DTO>(t);
        }

        public virtual async Task<bool> Update(DTO entity, IType id)
        {
            T t = null;

            if (MapDtoToEntity != null)
            {
                t = await GetQuery(
                    new CancellationToken(),
                    null, 
                    true).
                    FirstOrDefaultAsync(x=>x.Id.Equals(id));

               if(t == null)
               {
                    throw new NotFoundException();
               }
                MapDtoToEntity(entity, t);
            }
            else
            {
                t =
                 Mapper.Map<T>(entity);
            }

            bool result =
                await BaseService.Update(t);

            if (result)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(DTO entity)
        {
            T t =
                 Mapper.Map<T>(entity);

            if (t == null)
            {
                throw new NotFoundException();
            }

            bool result =
                await BaseService.Delete(t);

            if (result)
            {
                return true;
            }
            return false;
        }

        public virtual async Task<DTO?> Get(IType id,
           CancellationToken cancellationToken, Guid? organizationId, bool include = false)
        {
            IQueryable<T> ts = BaseService
               .GetAll(cancellationToken);

            return Mapper.Map<DTO>(await
                 GetQuery(cancellationToken, organizationId, include)
                .FirstOrDefaultAsync(x => x.Id.Equals(id)));

        }

        public virtual async Task<List<DTO>> GetAll(
           CancellationToken cancellationToken, Guid? organizationId, bool include = false)
        {
            return Mapper.Map<List<DTO>>( await
                GetQuery(cancellationToken, organizationId, include)
                .ToListAsync());
        }


        public IQueryable<T> GetQuery(
           CancellationToken cancellationToken, Guid? organizationId, bool include = false)
        {
            IQueryable<T> query = null;
            if (include)
            {
                if (Include != null)
                {
                    query = BaseService
                       .GetAll(cancellationToken);

                    query = Include(query);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                query = BaseService
                  .GetAll(cancellationToken);
            }

            var pi = typeof(T).GetProperty("OrganizationId");
            if (pi != null && organizationId != null)
            {
                query = query
                    .Where(x => !x.Deleted)
                    .Where(LambdaConstructor("OrganizationId", organizationId.ToString()));
            }
            else
            {
                query = query
                    .Where(x => !x.Deleted);
            }

            return query;
        }

        private Expression<Func<T, bool>> LambdaConstructor(string propertyName, string inputText)
        {

            var item = Expression.Parameter(typeof(T), "item");
            var prop = Expression.Property(item, propertyName);
            var propertyInfo = typeof(T).GetProperty(propertyName);
            var value = Expression.Constant(Convert.ChangeType(new Guid(inputText), propertyInfo.PropertyType));
            BinaryExpression equal = Expression.Equal(prop, value);

            var lambda = Expression.Lambda<Func<T, bool>>(equal, item);
            return lambda;
        }
    }

}

