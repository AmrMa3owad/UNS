using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Craft : BaseEntity<int>
    {
        public Craft()
        {
            Mentors = new HashSet<Mentor>();
        }
        public string CraftName { get; set; }
        public string CraftType { get; set; }

        public virtual ICollection<Mentor> Mentors { get; set; }
    }
}
