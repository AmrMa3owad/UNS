using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Admin : BaseEmployee<int>
    {
        public Admin()
        {  
            Feedbacks = new HashSet<Feedback>();
            ContactUses = new HashSet<ContactUs>();
            Categories = new HashSet<Category>();
        }
        public byte[] Image { get; set; }     
        public int? WebsiteId { get; set; }
        public int? DeviceId { get; set; }
   
        public virtual Website Website { get; set; }
        public virtual Device Device { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<ContactUs> ContactUses { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

    }
}
