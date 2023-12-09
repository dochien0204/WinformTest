using ProjectProduct.Models;
using ProjectProduct.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private decimal productId;
        public ProductDetail(ProductUseCase service, decimal productId)
        {
            this.service = service;
            this.productId = productId;
            InitializeComponent();
            InitTextBoxValue();
        }

        private void InitTextBoxValue()
        {
            Product product = service.GetProductById(productId);
            tbProductId.Text = product.Id.ToString();
            tbProductName.Text = product.Name;
        }
    }
}
