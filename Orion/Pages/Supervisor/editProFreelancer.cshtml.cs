using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.IO;
using System.Threading.Tasks;

namespace Orion.Pages.Supervisor
{
    public class editProFreelancerModel : PageModel
    {
        private readonly IFreelancerService _freelancerService;

        public editProFreelancerModel(IFreelancerService freelancerService)
        {
            _freelancerService = freelancerService;
        }

        [BindProperty]
        public Freelancer Freelancer { get; set; }

        [BindProperty]
        public IFormFile ProfilePicture { get; set; }

        public async Task<IActionResult> OnGetAsync(int freelancerId)
        {
            Freelancer = await _freelancerService.Get(freelancerId, new CancellationToken());

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Freelancer = await _freelancerService.Get(Freelancer.UserId, new CancellationToken());

            if (ProfilePicture != null && ProfilePicture.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await ProfilePicture.CopyToAsync(memoryStream);
                    Freelancer.StarPhoto = memoryStream.ToArray();
                }
            }

            // Update the entity in the database
            var updateResult = await _freelancerService.Update(Freelancer);

            if (!updateResult)
            {
                // Handle update failure (e.g., concurrency issue)
                return Page();
            }

            return RedirectToPage("/Supervisor/childsProfile", new { freelancerId = Freelancer.UserId }); // Redirect to profile page
        }
    }
}
