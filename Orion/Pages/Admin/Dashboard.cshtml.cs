using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Admin
{
    public class DashboardModel : PageModel
    {
        private readonly IOrphanageService _orphanageService;
        private readonly IFreelancerService _freelancerService;
        private readonly ISupervisorService _supervisorService;
        private readonly IProductService _productService;
        private readonly ICartService _cartService;
        private readonly ISponsorService _sponsorService;
        private readonly IDonationService _donationService;
        private readonly IMaterialService _materialService;

        public int OrphCount { get; set; }
        public int FreeCount { get; set; }
        public int SuperCount { get; set; }
        public int ProdCount { get; set; }
        public int SponsCount { get; set; }
        public int CartCount { get; set; }
        public double? MatCount { get; set; }
        public double DonCount { get; set; }
        public double? RevCount { get; set; }

        public DashboardModel(IOrphanageService orphanageService, 
            IFreelancerService freelancerService,
            ISupervisorService supervisorService,
            IProductService productService,
            ICartService cartService,
            ISponsorService sponsorService,
            IDonationService donationService,
            IMaterialService materialService)
        {
            _orphanageService = orphanageService;
            _freelancerService = freelancerService;
            _supervisorService = supervisorService;
            _productService = productService;
            _cartService = cartService;
            _sponsorService = sponsorService;
            _donationService = donationService;
            _materialService = materialService;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            var Orphanages = await _orphanageService.GetAll(new CancellationToken()).ToListAsync();
            var Freelancers = await _freelancerService.GetAll(new CancellationToken()).ToListAsync();
            var Supervisors = await _supervisorService.GetAll(new CancellationToken()).ToListAsync();
            var Products = await _productService.GetAll(new CancellationToken()).ToListAsync();
            var Sponsers = await _sponsorService.GetAll(new CancellationToken()).ToListAsync();
            var Carts = await _cartService.GetAll(new CancellationToken()).ToListAsync();
            var Materials = await _materialService.GetAll(new CancellationToken()).ToListAsync();
            var Donations = await _donationService.GetAll(new CancellationToken()).ToListAsync();

            OrphCount = Orphanages.Count;
            FreeCount = Freelancers.Count;
            SuperCount = Supervisors.Count;
            ProdCount = Products.Count;
            SponsCount = Sponsers.Count;
            CartCount = Carts.Count;
            MatCount = Materials.Sum(x => x.MaterialPrice);
            DonCount = Donations.Sum(x => x.DonationQuantity);
            RevCount = Carts.Sum(x => x.TotalPrice);
            return Page();
        }
    }
}
