using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Infrastructure.Services;
using System.ComponentModel.DataAnnotations;

namespace Orion.Pages.Admin
{
    public class changepassModel : PageModel
    {
        private readonly ILogger<changepassModel> _logger;
        private readonly IUserService _userService; 

        [BindProperty]
        [Required(ErrorMessage = "Old password is required.")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "New password is required.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Confirmation password is required.")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public changepassModel(ILogger<changepassModel> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string userEmail = User.Identity.Name; 
            var user = await _userService.GetByEmail(userEmail, new System.Threading.CancellationToken());

            if (user != null)
            {
                var result = await _userService.ChangePassword(user, OldPassword, NewPassword);

                if (result.Succeeded)
                {
                    return RedirectToPage("/Admin/login"); 
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return Page();
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "User not found.");
                return Page();
            }
        }
    }
}
