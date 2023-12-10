using GrapeCity.CalcEngine;
using ProjectProduct.Controllers.Presenters.ListProduct;
using ProjectProduct.Controllers.Presenters.ProductDetail;
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
                ProductDataGridView productView = new ProductDataGridView(product.Id, product.Name);
                listProductView.Add(productView);
            }

            return listProductView;
        }

        public static List<ComponentPresenter> convertListComponentToPresenter(List<Component> components)
        {
            List<ComponentPresenter> componentPresenters = new List<ComponentPresenter>();
            foreach (Component component in components)
            {
                ComponentPresenter componentPresenter = new ComponentPresenter(component.Id, component.Name);
                componentPresenters.Add(componentPresenter);
            }
            
            return componentPresenters;
        }

    }
}
