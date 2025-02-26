using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using System.Threading.Tasks;

namespace Orion.Pages.EndUser
{
    public class feedbackModel : PageModel
    {
        [BindProperty]

        public ContactUs ContactUs { get; set; }

        private readonly IContactUsService _contactUsService;

        public feedbackModel(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            
            await _contactUsService.Create(ContactUs);

            return Page();
        }
    }
}
