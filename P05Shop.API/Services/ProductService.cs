using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;
using P07Shop.DataSeeder;

namespace P05Shop.API.Services
{
    public class ProductService : IProductService
    {

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var result = new ServiceResponse<List<Product>>();

            try
            {
                result.Data = ProductDataSeeder.GenerateProductData();
                result.Success = true;
                result.Message = "Products retrieved successfully.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"An error occurred while retrieving products: {ex.Message}";

            }
            return result;
        }
    }
}
