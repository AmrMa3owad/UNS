using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Orion.Pages.EndUser;
public class detailsModel : PageModel
{
    private readonly IProductService _productService;
    private readonly IFeedbackService _feedbackService;
    public Product Product { get; set; }
    public List<Feedback> Feedbacks { get; set; }
    [BindProperty]
    public Feedback Feedback { get; set; }
    [BindProperty(SupportsGet = true)]
    public int ProductId { get; set; }

    public detailsModel(IProductService productService, IFeedbackService feedbackService)
    {
        _productService = productService;
        _feedbackService = feedbackService;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        Product = await _productService.Get(ProductId, new CancellationToken());
        Feedbacks = await _feedbackService.GetAll(new CancellationToken()).ToListAsync();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        Feedback.ProductId = ProductId;
        await _feedbackService.Create(Feedback);

        var product = await _productService.Get(ProductId, new CancellationToken());
        if (product != null)
        {
            product.Feedbacks.Add(Feedback);
            await _productService.Update(product);
        }

        return RedirectToPage();
    }
}
