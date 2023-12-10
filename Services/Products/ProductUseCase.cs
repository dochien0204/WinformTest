using ProjectProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Services.Products
{
    public interface ProductUseCase
    {
        public List<Product> GetAll();
        public List<Product> GetListProductByName(string name);
        public Product GetProductById(decimal id);
    }
}
