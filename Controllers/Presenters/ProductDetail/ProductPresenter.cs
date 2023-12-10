using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Controllers.Presenters.ProductDetail
{
    internal class ProductPresenter
    {
        public decimal Id { get; set; }
        public string Name { get; set; } = null!;
        public List<ComponentPresenter> Components { get; set; }
        public ProductPresenter(decimal Id, string Name, List<ComponentPresenter> components)
        {
            this.Id = Id;
            this.Name = Name;
            this.Components = components;
        }

    }
}
