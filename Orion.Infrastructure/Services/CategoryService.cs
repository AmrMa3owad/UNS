using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class CategoryService
       : BaseService<Category, int>,
           ICategoriesService 
    {
        public CategoryService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}
