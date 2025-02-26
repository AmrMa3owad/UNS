using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class orphanageSSSModel : PageModel
    {
        private readonly IOrphanageService _orphanageService;

        public List<Orphanage> Orphanages { get; set; }

        public orphanageSSSModel(IOrphanageService orphanageService)
        {
            _orphanageService = orphanageService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Orphanages = await _orphanageService.GetAll(new CancellationToken()).ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var orphanage = await _orphanageService.Get(id, new CancellationToken());

            await _orphanageService.Delete(orphanage);
           
            return RedirectToPage();
        }

    }
}
