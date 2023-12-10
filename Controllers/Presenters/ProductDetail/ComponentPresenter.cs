using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Controllers.Presenters.ProductDetail
{
    internal class ComponentPresenter
    {
        [DisplayName("Component Id")]
        public decimal Id { get; set; }
        [DisplayName("Component Name")]
        public string Name { get; set; } 
        public ComponentPresenter(decimal id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
