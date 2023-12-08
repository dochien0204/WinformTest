using ProjectProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Repository.Products
{
    public interface IProductRepository
    {
        public List<Product> GetAll();
    }
}
