using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class CustomerProduct : BaseEntity<int>
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
