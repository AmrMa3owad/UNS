using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Booth : BaseEntity<int>
    {
        public Booth()
        {
            BoothOrders = new HashSet<BoothOrder>();
        }
        public int BoothNumber { get; set; }
        public int BoothCapacity { get; set; }
        public string BoothPlace { get; set; }
        public int? EventId { get; set; }

        public virtual Event Event { get; set; }
        public virtual ICollection<BoothOrder> BoothOrders { get; set; }
    }
}
