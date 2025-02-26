using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Pages
{
    public class UserModel : PageModel
    {
        private readonly AppDbContext _context;

        public UserModel(AppDbContext context)
        {
            _context = context;
        }

        public List<User> Users { get; set; }

        public void OnGet()
        {
            Users = _context.Users.ToList();
        }
    }
}
