using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Customer : BaseUser<int>
    {
        public Customer()
        {
            CustomerProducts = new HashSet<CustomerProduct>();
            CustomerAdvertisements = new HashSet<CustomerAdvertisement>();
            Events = new HashSet<Event>();
            Feedbacks = new HashSet<Feedback>();
            ContactUses = new HashSet<ContactUs>();
        }
        public int? DonationId { get; set; }
        public int? PaymentId { get; set; }
        public int? OrderId { get; set; }
        public int? WebsiteId { get; set; }
        public int? PreCommunityId { get; set; }

        public virtual User User { get; set; }
        public virtual Donation Donation { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Order Order { get; set; }
        public virtual Website Website { get; set; }
        public virtual PreCommunity PreCommunity { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
        public virtual ICollection<CustomerAdvertisement> CustomerAdvertisements { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<ContactUs> ContactUses { get; set; }
    }
}
