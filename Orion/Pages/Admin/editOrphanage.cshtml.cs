using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Infrastructure.Services;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Pages.Admin
{
    public class editOrphanageModel : PageModel
    {
        private readonly IOrphanageService _orphanageService;

        public editOrphanageModel(IOrphanageService orphanageService)
        {
            _orphanageService = orphanageService;
        }

        [BindProperty]
        public Domain.Models.Orphanage Orphanage { get; set; }

        [BindProperty]
        public IFormFile ProfilePicture { get; set; }

        public async Task<IActionResult> OnGetAsync(int orphanageId)
        {
            Orphanage = await _orphanageService.Get(orphanageId, new CancellationToken());

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ProfilePicture != null && ProfilePicture.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await ProfilePicture.CopyToAsync(memoryStream);
                    Orphanage.OrphanageLogo = memoryStream.ToArray();
                }
            }

            var updateResult = await _orphanageService.Update(Orphanage);
            if (!updateResult)
            {
                return Page();
            }

            return RedirectToPage("/Admin/orphanageAdmin", new { orphanageId = Orphanage.Id });
        }
    }
}
