using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class SupervisorOrphanage : BaseEntity<int>
    {
        public int SupervisorId { get; set; }
        public int OrphanageId { get; set; }

        public virtual Supervisor Supervisor { get; set; }
        public virtual Orphanage Orphanage { get; set; }
    }
}
