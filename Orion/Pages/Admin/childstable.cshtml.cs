using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class childstableModel : PageModel
    {
        private readonly IFreelancerService _freelancerService;

        public List<Freelancer> Freelancers { get; set; }

        public childstableModel(IFreelancerService freelancerService)
        {
            _freelancerService = freelancerService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Freelancers = await _freelancerService.GetAllInclude(new CancellationToken());
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var freelancer = await _freelancerService.Get(id, new CancellationToken());

            await _freelancerService.Delete(freelancer);

            return RedirectToPage();
        }

    }
}
