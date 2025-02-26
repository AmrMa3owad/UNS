using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.IO;
using System.Threading.Tasks;

namespace Orion.Pages.Supervisor
{
    public class editProModel : PageModel
    {
        private readonly ISupervisorService _supervisorService;

        public editProModel(ISupervisorService supervisorService)
        {
            _supervisorService = supervisorService;
        }

        [BindProperty]
        public Domain.Models.Supervisor Supervisor { get; set; }

        [BindProperty]
        public IFormFile ProfilePicture { get; set; }

        public async Task<IActionResult> OnGetAsync(int supervisorId)
        {
            Supervisor = await _supervisorService.Get(supervisorId,new CancellationToken());

          
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Supervisor = await _supervisorService.Get(Supervisor.EmployeeId, new CancellationToken());

            if (ProfilePicture != null && ProfilePicture.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await ProfilePicture.CopyToAsync(memoryStream);
                    Supervisor.SupervisorPhoto = memoryStream.ToArray();
                }
            }

            // Update the entity in the database
            var updateResult = await _supervisorService.Update(Supervisor);

            if (!updateResult)
            {
                // Handle update failure (e.g., concurrency issue)
                return Page();
            }

            return RedirectToPage("/Supervisor/superProfile"); // Redirect to profile page
        }
    }
}
