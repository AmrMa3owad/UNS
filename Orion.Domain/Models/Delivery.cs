using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Delivery : BaseEntity<int> 
    {
        public Delivery()
        {
            DeliveryOrders = new HashSet<DeliveryOrder>();
        }
        public int VechileNumber { get; set; }
        public string DeliveryLicense { get; set; }
        public int DeliveryPhone { get; set; }

        public virtual ICollection<DeliveryOrder> DeliveryOrders { get; set; }
    }
}
