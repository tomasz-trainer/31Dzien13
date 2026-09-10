using P06Shop.Shared;

namespace P05Shop.API.Services
{
    public class ProductService
    {

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var result = new ServiceResponse<List<Product>>();

            try
            {
                result.Data = new List<Product>() { };
                result.Success = true;
                result.Message = "Products retrieved successfully.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"An error occurred while retrieving products: {ex.Message}";

            }
        }
    }
}
