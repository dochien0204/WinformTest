using ProjectProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Repository.Components
{
    internal interface IComponentRepository
    {
        public List<Component> GetListComponentByProductId(decimal productId);
    }
}
