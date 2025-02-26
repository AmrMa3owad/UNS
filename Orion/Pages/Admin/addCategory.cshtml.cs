using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class addCategoryModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }

        [BindProperty]
        public IFormFile CategoryImageFile { get; set; }
        private readonly ICategoriesService _CategoryService;

        public addCategoryModel(ICategoriesService CategoryService)
        {
            _CategoryService = CategoryService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (CategoryImageFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await CategoryImageFile.CopyToAsync(memoryStream);
                    Category.Img = memoryStream.ToArray();
                }
            }

            await _CategoryService.Create(Category);

            return Page();
        }
    }
}
