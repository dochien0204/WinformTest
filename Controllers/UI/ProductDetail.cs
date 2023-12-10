using ProjectProduct.Controllers.Presenters.ProductDetail;
using ProjectProduct.Models;
using ProjectProduct.Services.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProduct.Controllers.UI
{
    public partial class ProductDetail : Form
    {
        private ProductUseCase service;
        private System.ComponentModel.BindingList<ComponentPresenter> componentList = new System.ComponentModel.BindingList<ComponentPresenter>();

        private decimal productId;
        public ProductDetail(ProductUseCase service, decimal productId)
        {
            this.service = service;
            this.productId = productId;
            InitializeComponent();
            InitTextBoxValueAndDataGridView();
        }

        private void InitTextBoxValueAndDataGridView()
        {
            Product product = service.GetProductById(productId);
            tbProductId.Text = product.Id.ToString();
            tbProductName.Text = product.Name;

            //Data grid view
            ICollection<Component> components = product.Components;
            dgComponent.DataSource = Common.convertListComponentToPresenter(components.ToList());
        }
    }
}
