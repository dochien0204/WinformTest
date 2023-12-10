using GrapeCity.CalcEngine;
using ProjectProduct.Models;
using ProjectProduct.Repository.Components;
using ProjectProduct.Repository.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Services.Products
{
    public class ProductService : ProductUseCase
    {
        private IProductRepository productRepo;
        private IComponentRepository componentRepo;

        public ProductService(IProductRepository productRepo, IComponentRepository componentRepo)
        {
            this.productRepo = productRepo;
            this.componentRepo = componentRepo;
        }

        public List<Product> GetAll()
        {
            return productRepo.GetAll();
        }

        public List<Product> GetListProductByName(string name)
        {
            return productRepo.GetProductsByName(name);
        }

        public Product GetProductById(decimal id)
        {
            return productRepo.GetProductById(id);
        }
    }
}
