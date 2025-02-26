using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;

namespace Orion.Pages.Admin
{
    public class verifyModel : PageModel
    {
        private readonly ILogger<verifyModel> _logger;

        [BindProperty]
        [Required(ErrorMessage = "Verification code is required.")]
        public string VerificationCode { get; set; }
        [TempData]
        public string GeneratedOTP { get; set; }

        public verifyModel(ILogger<verifyModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            GeneratedOTP = TempData["GeneratedOTP"] as string;
            if (GeneratedOTP == null)
            {
                return RedirectToPage("/Admin/email");
            }
            if (VerificationCode == GeneratedOTP)
            {
                return RedirectToPage("/Admin/changepass");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid verification code.");
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (VerificationCode == GeneratedOTP)
            {
                return RedirectToPage("/Admin/changepass");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid verification code.");
                return Page();
            }
        }
    }
}
