using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class ContactUsService
        : BaseService<ContactUs, int>,
            IContactUsService
    {
        public ContactUsService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}