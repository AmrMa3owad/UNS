using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class AddAdminModel : PageModel
    {
        public Domain.Models.Admin Admin { get; set; }
        public Employee Employee { get; set; }

        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string ConfirmPassword { get; set; }
        [BindProperty]
        public string PhoneNumber { get; set; }
        [BindProperty]
        public string Gender { get; set; }
        [BindProperty]
        public DateTime? DateOfBirth { get; set; }
        [BindProperty]
        public IFormFile ProfileImage { get; set; }
        [BindProperty]
        public string SupervisorRegion { get; set; }
        [BindProperty]
        public string SupervisorSkill { get; set; }

        private readonly IUserService _userService;
        private readonly IAdminService _adminService;
        private readonly IEmployeeService _employeeService;

        public AddAdminModel(IUserService userService, IAdminService adminService, IEmployeeService employeeService)
        {
            _userService = userService;
            _adminService = adminService;
            _employeeService = employeeService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAdminAsync()
        {
            if (DateOfBirth.HasValue)
            {
                DateOfBirth = DateTime.SpecifyKind(DateOfBirth.Value, DateTimeKind.Utc);
            }

            var user = new User
            {
                Gender = Gender,
                PhoneNumber = PhoneNumber,
                BirthDate = DateOfBirth,
                FirstName = FirstName,
                LastName = LastName,
                UserName = Username,
                Email = Email,
                PasswordHash = Password
            };

            var result = await _userService.Create(user, Password);

            if (!result.Succeeded)
            {
                return Page();
            }

            var employee = new Employee
            {
                UserId = user.Id
            };

            Employee = await _employeeService.Create(employee);

            var supervisor = new Domain.Models.Admin
            {               
                EmployeeId = employee.UserId
            };
            if (ProfileImage != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await ProfileImage.CopyToAsync(memoryStream);
                    supervisor.Image = memoryStream.ToArray();
                }
            }
            Admin = await _adminService.Create(supervisor);

            if (Admin != null)
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
