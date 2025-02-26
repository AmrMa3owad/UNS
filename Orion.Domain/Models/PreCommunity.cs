using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class PreCommunity : BaseEntity<int>
    {
        public PreCommunity()
        {
            Customers = new HashSet<Customer>();
        }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
