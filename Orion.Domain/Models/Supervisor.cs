using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Supervisor : BaseEmployee<int>
    {
        public Supervisor()
        {
            Freelancers = new HashSet<Freelancer>();
            Products = new HashSet<Product>();
            SupervisorOrphanages = new HashSet<SupervisorOrphanage>();
        }
        public byte[]? SupervisorPhoto { get; set; }
        public string? SupervisorSkill { get; set; }
        public string? SupervisorInfo { get; set; }
        public string? SupervisorRegion { get; set; }

        public virtual ICollection<Freelancer> Freelancers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<SupervisorOrphanage> SupervisorOrphanages { get; set; }
    }
}
