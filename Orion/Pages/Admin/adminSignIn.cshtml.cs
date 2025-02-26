using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class adminSignInModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public adminSignInModel(IUserService userService)
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
                return RedirectToPage("/Admin/Dashboard");
            }
            else
            {
                return Page();
            }
        }
    }
}
