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
                .OrderByDescending (p => p.Id)
                .ToList();
        }
    }
}
