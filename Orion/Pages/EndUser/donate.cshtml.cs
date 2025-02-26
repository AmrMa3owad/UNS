using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Pages.EndUser
{
    public class donateModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }

        [BindProperty]
        public double Quantity { get; set; }

        private readonly IDonationService _donationService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICustomerService _customerService;

        public donateModel(IDonationService donationService, IHttpContextAccessor httpContextAccessor, ICustomerService customerService)
        {
            _donationService = donationService;
            _httpContextAccessor = httpContextAccessor;
            _customerService = customerService;
        }

        public async Task<IActionResult> OnGetAsync()
        {                   
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var customerId = _httpContextAccessor.HttpContext.Session.GetInt32("CustomerID");          

            Customer = await _customerService.Get(customerId.Value, new CancellationToken());

            var donation = new Donation
            {
                DonationQuantity = Quantity,
                CustomerId = Customer.UserId
            };

            await _donationService.Create(donation);

            Customer.DonationId = donation.Id;
            await _customerService.Update(Customer);

            return Page(); 
        }
    }
}
