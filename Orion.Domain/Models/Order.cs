using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Order : BaseEntity<int>
    {
        public Order()
        {
            BoothOrders = new HashSet<BoothOrder>();
            DeliveryOrders = new HashSet<DeliveryOrder>();
        }
        public int OrderPrice { get; set; }
        public string OrderDate { get; set; }
        public string OrderType { get; set; }
        public int OrderAmount { get; set; }
        public string OrderComments { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<BoothOrder> BoothOrders { get; set; }
        public virtual ICollection<DeliveryOrder> DeliveryOrders { get; set;}
    }
}
