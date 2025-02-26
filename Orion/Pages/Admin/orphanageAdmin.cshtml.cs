using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Pages.Admin
{
    public class orphanageAdminModel : PageModel
    {
        private readonly IOrphanageService _orphanageService;

        public orphanageAdminModel(IOrphanageService orphanageService)
        {
            _orphanageService = orphanageService;
        }

        public Orphanage Orphanage { get; set; }
        public int ProductsNum { get; set; }
        public string? OrphanageRegion { get; set; }
        public byte[]? OrphanageImg { get; set; }
        public string? OrphanageInfo { get; set; }
        public List<Product> OrphanageProduct { get; set; }
        public int OrphanageFreelancer { get; set; }
        public string? OrphanageName { get; set; }

        public async Task<IActionResult> OnGetAsync(int orphanageId)
        {
            Orphanage = await _orphanageService.GetIncludeAsync(orphanageId, new CancellationToken());
            
            ProductsNum = Orphanage.Freelancers.SelectMany(x => x.Products).Count();
            OrphanageFreelancer = Orphanage.Freelancers.Count;
            OrphanageRegion = Orphanage.OrphanageRegion;
            OrphanageImg = Orphanage.OrphanageLogo;
            OrphanageInfo = Orphanage.OrphanageInfo;
            OrphanageProduct = Orphanage.Freelancers.SelectMany(x => x.Products).ToList();
            OrphanageName = Orphanage.OrphanageName;

            return Page();
        }
    }
}
