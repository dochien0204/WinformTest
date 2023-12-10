using ProjectProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Services.Components
{
    internal interface ComponentUseCase
    {
        public List<Component> GetListComponentByProduct(decimal productId);
    }
}
