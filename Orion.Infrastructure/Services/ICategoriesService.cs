using Orion.Domain.Models;
using Orion.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Infrastructure.Services
{
    public interface ICategoriesService :
        IBaseService<Category, int>
    {
    }
}
