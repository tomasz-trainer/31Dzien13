using Newtonsoft.Json;
using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace P03WeatherForecastWPF.Client.Services
{
    internal class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("api/product");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<Product>>>(json);
            return result;
        }
    }
}
