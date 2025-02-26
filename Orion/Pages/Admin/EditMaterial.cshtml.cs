using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Pages.Admin
{
    public class EditMaterialModel : PageModel
    {
        private readonly IMaterialService _materialService;

        public EditMaterialModel(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        [BindProperty]
        public Domain.Models.Material Material { get; set; }

        [BindProperty]
        public IFormFile MaterialPicture { get; set; }
        public int materialId { get; private set; }

        //public async Task<IActionResult> OnGetAsync(int materialId)
        //{
        //    Material = await _materialService.Get(materialId, new CancellationToken());

        //    return Page();
        //}

        public async Task<IActionResult> OnPostAsync()
        {
            if (MaterialPicture != null && MaterialPicture.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await MaterialPicture.CopyToAsync(memoryStream);
                    Material.Image = memoryStream.ToArray();
                }
            }

            var updateResult = await _materialService.Update(Material);
            if (!updateResult)
            {
                return Page();
            }

            return RedirectToPage("/Admin/materialAdmin", new { materialId = Material.Id });
        }
    }
 }
