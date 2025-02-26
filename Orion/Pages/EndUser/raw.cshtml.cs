using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using Orion.Models;

namespace Orion.Pages.EndUser
{
    public class rawModel : PageModel
    {
        private readonly IMaterialService _productService;
        private readonly ICartService _cartService;

        public Cart Cart { get; set; }
        public List<Material> Products { get; set; }
        public IEnumerable<string> ProNames { get; set; }
        public IEnumerable<byte[]?> ProductImg { get; set; }
        public IEnumerable<double?> ProductPrice { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ProductType { get; set; }

        public rawModel(IMaterialService productService, ICartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
        }

        public async Task<IActionResult> OnGet()
        {
            var allProducts = await _productService.GetAll(new CancellationToken()).ToListAsync();

            if (!string.IsNullOrEmpty(SearchQuery))
            {
                allProducts = allProducts.Where(p => p.MaterialName.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(ProductType))
            {
                allProducts = allProducts.Where(p => p.MaterialType.Equals(ProductType, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            Products = allProducts;
            ProNames = Products.Select(x => x.MaterialName);
            ProductImg = Products.Select(x => x.Image);
            ProductPrice = Products.Select(x => x.MaterialPrice);

            return Page();
        }

        public async Task<JsonResult> OnGetCartProductsAsync()
        {
            int? CartId = HttpContext.Session.GetInt32("CartId");
            if (CartId != null && CartId != 0)
            {
                Cart = await _cartService.GetCartIncludeAsync(CartId.Value, new CancellationToken());
                return new JsonResult(new { CartId = Cart.Id, Materials = Cart.Materials.Select(p => new { MaterialId = p.Id, MaterialName = p.MaterialName, MaterialPrice = p.MaterialPrice, MaterialImage = p.Image }).ToList() });

            }
            return new JsonResult(new { CartId = 0 });

        }

        public async Task<JsonResult> OnPostAddToCartAsync([FromBody] CartProduct cartProduct)
        {
            var product = await _productService.Get(cartProduct.MaterialId, new CancellationToken());

            if (!cartProduct.CartId.HasValue || cartProduct.CartId == 0)
            {
                Cart = new Cart();
                Cart = await _cartService.Create(Cart);
                HttpContext.Session.SetInt32("CartId", Cart.Id);

            }
            else
            {
                Cart = await _cartService.GetCartIncludeAsync(cartProduct.CartId.Value, new CancellationToken());
            }

            Cart.Materials.Add(product);
            Cart.NumberOfProducts = Cart.Materials.Count;
            Cart.TotalPrice = Cart.Materials.Sum(p => p.MaterialPrice) + Cart.Products.Sum(m => m.ProductPrice);
            await _cartService.Update(Cart);

            return new JsonResult(new { CartId = Cart.Id, Materials = Cart.Materials.Select(p => new { MaterialId = p.Id }).ToList() });
        }
    }
}