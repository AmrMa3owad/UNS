using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Supervisor
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public IFormFile ProductImageFile { get; set; }

        [BindProperty(SupportsGet = true)]
        public int FreelancerId { get; set; }

        private readonly IProductService _productService;
        private readonly IFreelancerService _freelancerService;

        public AddProductModel(IProductService productService, IFreelancerService freelancerService)
        {
            _productService = productService;
            _freelancerService = freelancerService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ProductImageFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await ProductImageFile.CopyToAsync(memoryStream);
                    Product.ProductImage = memoryStream.ToArray();
                }
            }

            Product.FreelancerId = FreelancerId;

            await _productService.Create(Product);

            var freelancer = await _freelancerService.GetFreelancerWithOrphanageAsync(FreelancerId, new System.Threading.CancellationToken());
            if (freelancer != null)
            {
                freelancer.Products.Add(Product);
                await _freelancerService.Update(freelancer);
            }

            return RedirectToPage("/Supervisor/childsProfile", new { freelancerId = FreelancerId }); 
        }
    }
}
