using GrapeCity.CalcEngine;
using ProjectProduct.Models;
using ProjectProduct.Repository.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Services
{
    public class ProductService: ProductUseCase
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
    }
}
