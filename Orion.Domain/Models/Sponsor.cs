using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Sponsor : BaseEntity<int>
    {
        public Sponsor()
        {
            SponsorAdvertisements = new HashSet<SponsorAdvertisement>();

        }
        public string? SponsorName { get; set; }
        public string? SponsorEmail { get; set; }
        public int? SponsorPhone { get; set; }
        public string? SponsorAddress { get; set; }
        public string? BusinessType { get; set; }
        public int? DonationId { get; set; }
        public int? EventId { get; set; }

        public virtual Donation Donation { get; set; }
        public virtual Event Event { get; set; }
        public virtual ICollection<SponsorAdvertisement> SponsorAdvertisements { get; set; }
    }
}
