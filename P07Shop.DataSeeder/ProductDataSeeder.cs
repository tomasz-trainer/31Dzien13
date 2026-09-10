using Bogus;
using P06Shop.Shared;

namespace P07Shop.DataSeeder
{
    public class ProductDataSeeder
    {
        public static List<Product> GenerateProductData()
        {
            var prodcutFaker = new Faker<Product>()
                .RuleFor(p => p.Id, f => f.IndexFaker + 1)
                .RuleFor(p => p.Title, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription());

            var products = prodcutFaker.Generate(100);

            return products;
        }
    }
}
