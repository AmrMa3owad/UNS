using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;
using Orion.Infrastructure.Services;
using static System.Net.Mime.MediaTypeNames;


namespace Orion.Pages.Admin
{
    public class adminMaterialModel : PageModel
    {
        private readonly IMaterialService _MaterialService;
       

        public List<Material> Material { get; set; }
        public IEnumerable<string> MaterialName { get; set; }
        public IEnumerable<byte[]?> Image { get; set; }
        public IEnumerable<double?> MaterialPrice { get; set; }


        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MaterialType { get; set; }

        public adminMaterialModel(IMaterialService MaterialService)
        {
            _MaterialService = MaterialService;
        }

        public async Task<IActionResult> OnGet()
        {
            var allMaterials = await _MaterialService.GetAll(new CancellationToken()).ToListAsync();

            if (!string.IsNullOrEmpty(SearchQuery))
            {
                allMaterials = allMaterials.Where(p => p.MaterialName.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(MaterialType))
            {
                allMaterials = allMaterials.Where(p => p.MaterialType.Equals(MaterialType, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            Material = allMaterials;
            MaterialName = Material.Select(x => x.MaterialName);
            Image = Material.Select(x => x.Image);
            MaterialPrice = Material.Select(x => x.MaterialPrice);

            return Page();
        }

        //public async Task<JsonResult> OnPostAddToCartAsync([FromBody] CartProduct cartProduct)
        //{
        //    var product = await _MaterialService.Get(cartProduct.ProductId, new CancellationToken());

        //    if (!cartProduct.CartId.HasValue)
        //    {
        //        Cart = new Cart();
        //        Cart = await _cartService.Create(Cart);
        //    }
        //    else
        //    {
        //        Cart = await _cartService.Get(cartProduct.CartId.Value, new CancellationToken());
        //    }

        //    Cart.Products.Add(product);
        //    Cart.NumberOfProducts = Cart.Products.Count;
        //    Cart.TotalPrice = Cart.Products.Sum(p => p.ProductPrice);
        //    await _cartService.Update(Cart);

        //    return new JsonResult(new { CartId = Cart.Id, Products = Cart.Products.Select(p => new { ProductId = p.Id }).ToList() });
        //}
    }
}
