using CommunityToolkit.Mvvm.ComponentModel;
using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace P03WeatherForecastWPF.Client.ViewModels
{
    public partial class ProductsViewModel : ObservableObject
    {

        private readonly IProductService _productService;

        [ObservableProperty]
        private ObservableCollection<Product> _products;

        public ProductsViewModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task LoadProductsAsync()
        {
            var response = await _productService.GetProductsAsync();
            if (response.Success && response.Data != null)
            {
                Products = new ObservableCollection<Product>(response.Data);
            }
            else
            {
                // Handle error (e.g., log it, show a message to the user, etc.)
                 Products = new ObservableCollection<Product>();
            }
        }

    }
}
