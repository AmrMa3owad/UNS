using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;

namespace Orion.Pages.EndUser
{
    public class MaterialDetailsModel : PageModel

    {
        private readonly IMaterialService _materialService;

        public Material Material { get; set; }


        [BindProperty(SupportsGet = true)]
        public int MaterialId { get; set; }
        //public IEnumerable<string> Mail { get; set; }
        //public IEnumerable<string> Msg { get; set; }

        public MaterialDetailsModel(IMaterialService materialService)
        {
            _materialService = materialService;
        }

       


    //    public async Task<IActionResult> OnPostAsync()
    //    {

    //        await _feedbackService.Create(Feedback);
    //        Feedback.ProductId = ProductId;

    //        var freelancer = await _productService.Get(ProductId, new System.Threading.CancellationToken());
    //        if (freelancer != null)
    //        {
    //            freelancer.Feedbacks.Add(Feedback);
    //            await _productService.Update(freelancer);
    //        }

    //        return Page();
    //    }
    }
}
