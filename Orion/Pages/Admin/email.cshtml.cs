using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;

namespace Orion.Pages.Admin
{
    public class emailModel : PageModel
    {
        private readonly ILogger<emailModel> _logger;

        [BindProperty]
        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [TempData]
        public string GeneratedOTP { get; set; }

        public emailModel(ILogger<emailModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {       
            GeneratedOTP = GenerateOTP();
            TempData["GeneratedOTP"] = GeneratedOTP;

            return RedirectToPage("/Admin/verify");
        }

        private string GenerateOTP()
        {
            Random random = new Random();
            int otpNumber = random.Next(100000, 999999);
            return otpNumber.ToString();
        }
    }
}
