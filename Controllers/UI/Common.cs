using GrapeCity.CalcEngine;
using ProjectProduct.Controllers.Presenters;
using ProjectProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Controllers.UI
{
    internal class Common
    {
        public static List<ProductDataGridView> convertListProductToDataGridViewPresenter(List<Product> products)
        {
            List<ProductDataGridView> listProductView = new List<ProductDataGridView>();
            foreach (Product product in products)
            {
                ProductDataGridView productView = new ProductDataGridView(product.Id.ToString(), product.Name);
                listProductView.Add(productView);
            }

            return listProductView;
        }
    }
}
