using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Orion.Pages.EndUser
{
    public class SignModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly ICustomerService _customerService;
        private readonly ILogger<SignModel> _logger;

        public Customer Customer { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        public SignModel(IUserService userService, ICustomerService customerService, ILogger<SignModel> logger)
        {
            _userService = userService;
            _customerService = customerService;
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostSignInAsync()
        {
            ModelState.Clear(); // Clear existing errors

            var result = await _userService.SignIn(Email, Password, new System.Threading.CancellationToken());
            if (result.Succeeded)
            {
                var user = await _userService.GetByEmail(Email, new System.Threading.CancellationToken());
                if (user != null)
                {
                    var customer = await _customerService.Get(user.Id, new System.Threading.CancellationToken());
                    if (customer != null)
                    {
                        HttpContext.Session.SetInt32("CustomerID", user.Id);
                        HttpContext.Session.SetInt32("CartId", 0);
                        return RedirectToPage("/EndUser/Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "The account is not associated with a customer.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "User not found.");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostSignUpAsync()
        {
            ModelState.Clear(); // Clear existing errors

            var existingUserByEmail = await _userService.GetByEmail(Email, new System.Threading.CancellationToken());
            var existingUserByUsername = await _userService.GetAll(new System.Threading.CancellationToken()).FirstOrDefaultAsync(u => u.UserName == Username);

            if (existingUserByEmail != null)
            {
                ModelState.AddModelError("Email", "Email is already taken.");
            }

            if (existingUserByUsername != null)
            {
                ModelState.AddModelError("Username", "Username is already taken.");
            }

            // Validate password
            if (!IsValidPassword(Password))
            {
                ModelState.AddModelError("Password", "Invalid password format.");
            }

            // Check if passwords match
            if (Password != ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "Passwords do not match.");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = new User
            {
                UserName = Username,
                Email = Email,
                PasswordHash = Password
            };

            var result = await _userService.Create(user, Password);
            if (result.Succeeded)
            {
                var customer = new Customer
                {
                    UserId = user.Id
                };
                Customer = await _customerService.Create(customer);

                var signInResult = await _userService.SignIn(user.Email, Password, new System.Threading.CancellationToken());
                if (signInResult.Succeeded)
                {
                    return RedirectToPage("/EndUser/Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Registration failed.");
            return Page();
        }

        private bool IsValidPassword(string password)
        {
            // Custom password validation logic (example)
            if (string.IsNullOrEmpty(password) || password.Length < 7)
            {
                return false;
            }

            return true;
        }
    }
}
