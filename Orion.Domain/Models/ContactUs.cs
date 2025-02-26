using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class ContactUs : BaseEntity<int>
    {
        public string Mail { get; set; }
        public string Msg { get; set; }
        public int? CustomerId { get; set; }
        public int? AdminId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
