
using P05Shop.API.Services;
using P06Shop.Shared.Services.ProductService;

namespace P05Shop.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();


            builder.Services.AddScoped<IProductService, ProductService>();

            // addScoped - oznacza, że w trakcie jednego requestu będzie istniała tylko jedna instancja klasy ProductService
            // addTransient - oznacza, że obiekt będzie tworzony za każdym razem, gdy odwolujemy się do niego
            // addSingleton - oznacza, że obiekt będzie tworzony tylko raz i będzie istniał tak długo, jak długo istnieje aplikacja


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
