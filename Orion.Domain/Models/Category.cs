using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Category : BaseEntity<int>
    {
        public string? Name { get; set; }
        public byte[]? Img { get; set; }
        public string? SubCategory { get; set; }
        public int? AdminId { get; set; }

        public virtual Admin Admin { get; set; }
    }
}
