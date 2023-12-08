using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProjectProduct.Models
{
    public partial class Product
    {
        [DisplayName("Product Id")]
        public decimal Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; } = null!;
    }
}
