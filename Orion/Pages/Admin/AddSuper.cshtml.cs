using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Orion.Pages.Admin
{
    public class AddSuperModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        [BindProperty]
        public Domain.Models.Supervisor Supervisor { get; set; }
        public Employee Employee { get; set; }

        [BindProperty]
        public IFormFile SupervisorImageFile { get; set; }
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
        public string SupervisorRegion { get; set; }
        [BindProperty]
        public string SupervisorSkill { get; set; }


        private readonly IUserService _userService;
        private readonly ISupervisorService _supervisorService;
        private readonly IEmployeeService _employeeService;

        public AddSuperModel(IUserService userService, ISupervisorService supervisorService, IEmployeeService employeeService)
        {
            _userService = userService;
            _supervisorService = supervisorService;
            _employeeService = employeeService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
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

            var supervisor = new Domain.Models.Supervisor
            {
                EmployeeId = employee.UserId,
                SupervisorRegion = SupervisorRegion,
                SupervisorSkill = SupervisorSkill,
            };
            if (SupervisorImageFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await SupervisorImageFile.CopyToAsync(memoryStream);
                    supervisor.SupervisorPhoto = memoryStream.ToArray();
                }
            }
            Supervisor = await _supervisorService.Create(supervisor);

            if (Supervisor != null)
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
