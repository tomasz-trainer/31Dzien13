using Microsoft.AspNetCore.Mvc;
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

        }

    }
}
