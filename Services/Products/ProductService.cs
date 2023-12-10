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

        public ProductService(IProductRepository productRepo)
        {
            this.productRepo = productRepo;
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
