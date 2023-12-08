using FarPoint.Win.Spread;
using ProjectProduct.Controllers.Presenters;
using ProjectProduct.Controllers.UI;
using ProjectProduct.Models;
using ProjectProduct.Services;

namespace ProjectProduct
{
    public partial class Form1 : Form
    {
        private ProductUseCase service;

        private List<ProductDataGridView> dataGridView = new List<ProductDataGridView>();
        public Form1(ProductUseCase service)
        {
            this.service = service;
            InitializeComponent();
            InItDataGridView();
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InItDataGridView()
        {
            List<Product> products = service.GetAll();
            dgProduct.DataSource = Common.convertListProductToDataGridViewPresenter(products); ;
        }
    }
}
