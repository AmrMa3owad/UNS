using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Supervisor
{
    public class superSignupModel : PageModel
    {
        private readonly ISupervisorService _supervisorService;
        private readonly IUserService _userService;
        private readonly IEmployeeService _employeeService;

        public superSignupModel(ISupervisorService supervisorService, IUserService userService, IEmployeeService employeeService)
        {
            _supervisorService = supervisorService;
            _userService = userService;
            _employeeService = employeeService;
        }

        public Domain.Models.Supervisor Supervisor { get; set; }
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
        public List<SupervisorOrphanage> SelectedOrphanages { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostSignUpAsync()
        {
            if (DateOfBirth.HasValue)
            {
                DateOfBirth = DateTime.SpecifyKind(DateOfBirth.Value, DateTimeKind.Utc);
            }

            var user = new User
            {
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
                return Page(); // If user creation fails, return the current page
            }

            var employee = new Employee
            {
                UserId = user.Id
            };

            Employee = await _employeeService.Create(employee);
            
            var supervisor = new Domain.Models.Supervisor
            {
                SupervisorSkill = SupervisorSkill,
                SupervisorRegion = SupervisorRegion,
                SupervisorOrphanages = SelectedOrphanages,
                EmployeeId = employee.UserId 
            };
            if (ProfileImage != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await ProfileImage.CopyToAsync(memoryStream);
                    supervisor.SupervisorPhoto = memoryStream.ToArray();
                }
            }
            Supervisor = await _supervisorService.Create(supervisor);

            if (Supervisor != null)
            {
                return RedirectToPage("/Supervisor/superSignIn");
            }
            else
            {
                return Page();
            }
        }

    }
}