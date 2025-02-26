using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class SponsorAdvertisement : BaseEntity<int>
    {
        public int SponsorId { get; set; }
        public int AdvertisementId { get; set; }

        public virtual Advertisement Advertisement { get; set; }
        public virtual Sponsor Sponsor { get; set; }
    }
}
