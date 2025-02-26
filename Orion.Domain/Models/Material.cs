using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Material : BaseEntity<int>
    {
        public Material()
        {
            MaterialVendors = new HashSet<MaterialVendor>();

        }
        public string? MaterialName { get; set; }
        public string? MaterialDetails { get; set; }
        public double? MaterialPrice { get; set; }
        public byte[]? Image { get; set; }
        public string? MaterialSizes { get; set; }
        public string? MaterialColors { get; set; }

        public string? MaterialType { get; set; }
        public int? CartId { get; set; }

        //public int MaterialQuantity { get; set; }
        public virtual ICollection<MaterialVendor> MaterialVendors { get; set; }
        public virtual Cart Cart {  get; set; }

    }
}
