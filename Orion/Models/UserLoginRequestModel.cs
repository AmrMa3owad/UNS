using System.ComponentModel.DataAnnotations;

namespace Orion.Models
{
    public class UserLoginRequestModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
