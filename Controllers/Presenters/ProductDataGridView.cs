using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Controllers.Presenters
{
    internal class ProductDataGridView
    {
        [DisplayName("No")]
        public decimal Id { get;set; }
        [DisplayName("Product Name")]
        public string Name { get; set; } = null!;

        public ProductDataGridView(decimal id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
