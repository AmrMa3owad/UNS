using Microsoft.AspNetCore.Identity;
using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class User : IdentityUser<int> , IBaseEntity<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? UserType { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Password { get; set; }

        public virtual Freelancer Freelancer { get; set; }
        public virtual Mentor Mentor { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
