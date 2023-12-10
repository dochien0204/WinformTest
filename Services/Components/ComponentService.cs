using ProjectProduct.Models;
using ProjectProduct.Repository.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct.Services.Components
{
    internal class ComponentService: ComponentUseCase
    {
        private IComponentRepository componentRepo;

        public ComponentService(IComponentRepository componentRepo)
        {
            this.componentRepo = componentRepo;
        }

        public List<Component> GetListComponentByProduct(decimal productId)
        {
            return componentRepo.GetListComponentByProductId(productId);
        }
    }
}
