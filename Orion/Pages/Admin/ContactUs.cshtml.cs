using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using static System.Net.Mime.MediaTypeNames;
namespace Orion.Pages.Admin
{
    public class ContactUsModel : PageModel
    {
        private readonly IContactUsService _ContactUsService;


        public List<ContactUs> ContactUs { get; set; }
        public IEnumerable<string> Mail { get; set; }
        public IEnumerable<string> Msg { get; set; }
        public IEnumerable<int?> CustomerId { get; set; }
        public IEnumerable<int?> AdminId { get; set; }


        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        //[BindProperty(SupportsGet = true)]

        public ContactUsModel(IContactUsService ContactUsService)
        {
            _ContactUsService = ContactUsService;
        }

        public async Task<IActionResult> OnGet()
        {
            var allContactUs = await _ContactUsService.GetAll(new CancellationToken()).ToListAsync();

            if (!string.IsNullOrEmpty(SearchQuery))
            {
                allContactUs = allContactUs.Where(p => p.Mail.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            //if (!string.IsNullOrEmpty(MaterialType))
            //{
            //    allContactUs = allContactUs.Where(p => p.MaterialType.Equals(MaterialType, StringComparison.OrdinalIgnoreCase)).ToList();
            //}

            ContactUs = allContactUs;
            Mail = ContactUs.Select(x => x.Mail);
            Msg = ContactUs.Select(x => x.Msg);
            //MaterialPrice = ContactUs.Select(x => x.MaterialPrice);

            return Page();
        }
    }
}
