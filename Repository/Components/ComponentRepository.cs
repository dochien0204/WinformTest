using ProjectProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Repository.Components
{
    internal class ComponentRepository: IComponentRepository
    {
        private ModelContext context;

        public ComponentRepository(ModelContext context)
        {
            this.context = context;
        }

        public List<Component> GetListComponentByProductId(decimal productId)
        {
            var listComponent = context.Components
                .Where(c => c.ProductId == productId).ToList();
            return listComponent;
        }
    }
}
