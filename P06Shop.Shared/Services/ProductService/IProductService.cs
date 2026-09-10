using System;
using System.Collections.Generic;
using System.Text;

namespace P06Shop.Shared.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}
