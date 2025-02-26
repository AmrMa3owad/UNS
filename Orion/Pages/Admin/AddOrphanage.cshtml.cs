using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class AddOrphanageModel : PageModel
    {
        [BindProperty]
        public Orphanage Orphanage { get; set; }

        [BindProperty]
        public IFormFile OrphanageImageFile { get; set; }
        private readonly IOrphanageService _OrphanageService;

        public AddOrphanageModel(IOrphanageService OrphanageService)
        {
            _OrphanageService = OrphanageService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (OrphanageImageFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await OrphanageImageFile.CopyToAsync(memoryStream);
                    Orphanage.OrphanageLogo = memoryStream.ToArray();
                }
            }
            await _OrphanageService.Create(Orphanage);

            return Page();
        }
    }
}
