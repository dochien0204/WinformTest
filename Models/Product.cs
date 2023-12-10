using System;
using System.Collections.Generic;

namespace ProjectProduct.Models
{
    public partial class Product
    {
        public Product()
        {
            Components = new HashSet<Component>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Component> Components { get; set; }
    }
}
