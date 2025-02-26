using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Donation : BaseEntity<int>
    {
        public Donation()
        {
            Sponsors = new HashSet<Sponsor>();
        }
        public string? DonationType { get; set; }
        public double DonationQuantity { get; set; }
        public string? DonationTime { get; set; }
        public string? DonationMethod { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Sponsor> Sponsors { get; set; }
    }
}
