using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class MaterialVendor : BaseEntity<int>
    {
        public int MaterialId { get; set; }
        public int VendorId { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual Material Material { get; set; }
    }
}
