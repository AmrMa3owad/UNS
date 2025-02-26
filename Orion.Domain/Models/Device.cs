using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Device : BaseEntity<int>
    {
        public string DeviceType { get; set; }
        public string DeviceDateOfPurchase { get; set; }
        public string MaintenanceDate { get; set; }
        public int MaintenancePrice { get; set; }
        public int? AdminId { get; set; }
        public int? OfficeWorkerId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual OfficeWorker OfficeWorker { get; set; }

    }
}
