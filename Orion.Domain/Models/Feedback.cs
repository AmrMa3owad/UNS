using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Feedback : BaseEntity<int>
    {
        public int? CustomerId { get; set; }
        public int? AdminId { get; set; }
        public int? OfficeWorkerId { get; set; }
        public int? ProductId { get; set; }
        public string Mail { get; set; }
        public string Msg { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Product Product { get; set; }
        public virtual OfficeWorker OfficeWorker { get; set; }
    }
}
