using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Product : BaseEntity<int>
    {
        public Product()
        {
            CustomerProducts = new HashSet<CustomerProduct>();
            Feedbacks = new HashSet<Feedback>();
        }
        public string? ProductName { get; set; }
        public byte[]? ProductImage { get; set; }
        public string? ProductColor { get; set; }
        public int? ProductNumber { get; set; }
        public string? ProductType { get; set; }
        public string? ProductSize { get; set; }
        public string? Description { get; set; }
        public double? ProductPrice { get; set; }
        public string? Customization { get; set; }
        public int? SupervisorId { get; set; }
        public int? FreelancerId { get; set; }
        public int? EventId { get; set; }
        public int? CartId { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public virtual Event Event { get; set; }
        public virtual Cart Cart { get; set; }

        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public double? MaterialPrice { get; set; }
    }
}
