using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Infrastructure.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Pages.Supervisor
{
    public class superSignInModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public superSignInModel(IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostSignInAsync()
        {
            var result = await _userService.SignIn(Email, Password, new CancellationToken());
            if (result.Succeeded)
            {
                var user = await _userService.GetByEmail(Email,new CancellationToken());
                if (user != null)
                {
                    HttpContext.Session.SetInt32("SupervisorID", user.Id);
                    return RedirectToPage("/Supervisor/superProfile");
                }
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }
    }
}
