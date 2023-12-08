using Microsoft.Extensions.DependencyInjection;
using Oracle.ManagedDataAccess.Client;
using ProjectProduct.Models;
using ProjectProduct.Repository.Products;
using ProjectProduct.Services;

namespace ProjectProduct
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
           var serviceProvider = new ServiceCollection()
                .AddSingleton<ModelContext>()
                .AddSingleton<IProductRepository, ProductRepository>()
                .AddSingleton<ProductUseCase, ProductService>()
                .BuildServiceProvider();

            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var productService = serviceProvider.GetService<ProductUseCase>();
            Application.Run(new Form1(productService));
        }
    }
}