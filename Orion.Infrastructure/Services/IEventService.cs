using Orion.Infrastructure.Common;
using Orion.Domain.Models;

namespace Orion.Infrastructure.Services
{
    public interface IEventService :
        IBaseService<Event, int>
    {
    }
}
