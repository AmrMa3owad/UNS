using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Pages.EndUser
{
    public class orphanageModel : PageModel
    {
        private readonly IFreelancerService _freelancerService;

        public orphanageModel(IFreelancerService freelancerService)
        {
            _freelancerService = freelancerService;
        }

        public Freelancer Freelancer { get; set; }
        public int ProductsNum { get; set; }
        public string? OrphanageRegion { get; set; }
        public byte[]? OrphanageImg { get; set; }
        public string? OrphanageInfo { get; set; }
        public ICollection<Product> OrphanageProduct { get; set; }
        public int OrphanageFreelancer { get; set; }
        public string? OrphanageName { get; set; }

        public async Task<IActionResult> OnGetAsync(int freelancerId)
        {
            Freelancer = await _freelancerService.GetFreelancerWithOrphanageAsync(freelancerId, new CancellationToken());           

            ProductsNum = Freelancer.Products.Count;
            OrphanageFreelancer = Freelancer.Orphanage.Freelancers.Count;
            OrphanageRegion = Freelancer.Orphanage.OrphanageRegion;
            OrphanageImg = Freelancer.Orphanage.OrphanageLogo;
            OrphanageInfo = Freelancer.Orphanage.OrphanageInfo;
            OrphanageProduct = Freelancer.Products;
            OrphanageName = Freelancer.Orphanage.OrphanageName;

            return Page();
        }
    }
}
