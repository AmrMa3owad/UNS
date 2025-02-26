using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.Supervisor
{
    public class childProfileModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IFreelancerService _freelancerService;
        private readonly IUserService _userService;

        public childProfileModel(
            IProductService productService,
            IFreelancerService freelancerService,
            IUserService userService)
        {
            _productService = productService;
            _freelancerService = freelancerService;
            _userService = userService;
        }

        public List<Freelancer> Freelancers { get; set; }
        public Freelancer Freelancer { get; set; }

        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public int ProductsNum { get; set; }
        public DateTime? FreelancerAge { get; set; }
        public byte[] FreelancerImg { get; set; }
        public int FreelancerId { get; set; }
        public string? FreelancerInfo { get; set; }
        public ICollection<Product?> FreelancerProduct { get; set; }
        public string FreelancerOrphanage { get; set; }
        public int Age { get; set; }


        public async Task<IActionResult> OnGetAsync(int freelancerId)
        {
            Freelancer = await _freelancerService.GetFreelancerWithOrphanageAsync(freelancerId, new CancellationToken());

            ProductsNum = Freelancer.Products.Count;
            FreelancerAge = Freelancer.User.BirthDate;
            FreelancerImg = Freelancer.StarPhoto;
            FreelancerInfo = Freelancer.FreelancerDescription;
            FreelancerId = Freelancer.UserId;
            FreelancerProduct = Freelancer.Products;
            FreelancerOrphanage = Freelancer.Orphanage.OrphanageName;

            if (FreelancerAge.HasValue)
            {
                Age = CalculateAge(FreelancerAge.Value);
            }
            return Page();
        }
        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
