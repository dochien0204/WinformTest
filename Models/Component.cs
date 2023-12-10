using System;
using System.Collections.Generic;

namespace ProjectProduct.Models
{
    public partial class Component
    {
        public decimal Id { get; set; }
        public decimal? ProductId { get; set; }
        public string? Name { get; set; }

        public virtual Product? Product { get; set; }
    }
}
