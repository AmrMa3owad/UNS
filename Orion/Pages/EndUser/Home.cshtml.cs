using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Pages.EndUser
{
    public class HomeModel : PageModel
    {
        public List<Freelancer> Freelancer { get; set; } = new List<Freelancer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Orphanage> Orphanages { get; set; } = new List<Orphanage>();
        public int OrphanagesNum { get; set; }
        public int ProductsNum { get; set; }
        public int FreelancerNum { get; set; }

        private readonly IOrphanageService _orphanageService;
        private readonly IProductService _productService;
        private readonly IFreelancerService _freelancerService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeModel(IOrphanageService orphanageService,
                         IProductService productService,
                         IFreelancerService freelancerService,
                         IHttpContextAccessor httpContextAccessor)
        {
            _orphanageService = orphanageService;
            _productService = productService;
            _freelancerService = freelancerService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var cancellationToken = _httpContextAccessor.HttpContext.RequestAborted;

            Orphanages = await _orphanageService.GetAll(cancellationToken).ToListAsync();
            Products = await _productService.GetAll(cancellationToken).ToListAsync();
            Freelancer = await _freelancerService.GetAll(cancellationToken).ToListAsync();

            OrphanagesNum = Orphanages.Count;
            ProductsNum = Products.Count;
            FreelancerNum = Freelancer.Count;

            return Page();
        }
    }
}
