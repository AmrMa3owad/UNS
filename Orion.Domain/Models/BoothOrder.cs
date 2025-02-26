using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class BoothOrder : BaseEntity<int>
    {
        public int OrderId { get; set; }
        public int BoothId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Booth Booth { get; set; }

    }
}
