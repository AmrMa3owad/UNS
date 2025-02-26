using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class CustomerAdvertisement : BaseEntity<int>
    {
        public int CustomerId { get; set; }
        public int AdvertisementId { get; set; }

        public virtual Advertisement Advertisement { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
