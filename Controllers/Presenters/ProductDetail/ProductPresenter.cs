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
        private decimal Id { get; set; }
        private string Name { get; set; } = null!;
        public ProductPresenter(decimal Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
