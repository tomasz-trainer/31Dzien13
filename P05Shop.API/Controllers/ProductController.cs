using Microsoft.AspNetCore.Mvc;
using P05Shop.API.Services;
using P06Shop.Shared;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            ProductService productService = new ProductService();

            var result = await productService.GetProductsAsync();

            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
