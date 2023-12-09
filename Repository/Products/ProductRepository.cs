using GrapeCity.CalcEngine;
using ProjectProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Repository.Products
{
    public class ProductRepository: IProductRepository
    {
        private ModelContext context;

        public ProductRepository(ModelContext context)
        {
            this.context = context;
        }

        public List<Product> GetAll() {
            return context.Products
                .OrderByDescending (p => p.Name)
                .ToList();
        }

        public List<Product> GetProductsByName(string name)
        {
            var products = context.Products
                .Where(p => p.Name.Contains(name))
                .ToList();
            return products;
        }

        public Product GetProductById(decimal id) { 
            var product = context.Products
                .Single(p => p.Id == id);
            return product;
        }   
    }
}
