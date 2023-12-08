using FarPoint.Win.Spread;
using ProjectProduct.Controllers.Presenters;
using ProjectProduct.Controllers.UI;
using ProjectProduct.Models;
using ProjectProduct.Services;
using System.ComponentModel;

namespace ProjectProduct
{
    public partial class Form1 : Form
    {
        private ProductUseCase service;

        BindingList<ProductDataGridView> dataGridView = new BindingList<ProductDataGridView>();
        public Form1(ProductUseCase service)
        {
            this.service = service;
            InitializeComponent();
            InItDataGridView();
            InitAction();
        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitAction()
        {
            tbSearch.KeyDown += TextBoxKeyDown;
        }
        private void InItDataGridView()
        {
            //Hiden ID Col
            List<Product> products = service.GetAll();
            dataGridView = new BindingList<ProductDataGridView>(Common.convertListProductToDataGridViewPresenter(products));
            dgProduct.DataSource = dataGridView;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Product> listProductSearch = service.GetListProductByName(tbSearch.Text);
            if (listProductSearch == null) {
                MessageBox.Show("Cannot find!", "Notification");
            }

            dataGridView = new BindingList<ProductDataGridView>(Common.convertListProductToDataGridViewPresenter(listProductSearch));
            dgProduct.DataSource = dataGridView;
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Product> listProductSearch = service.GetListProductByName(tbSearch.Text);
                if (listProductSearch == null)
                {
                    MessageBox.Show("Cannot find!", "Notification");
                }

                dataGridView = new BindingList<ProductDataGridView>(Common.convertListProductToDataGridViewPresenter(listProductSearch));
                dgProduct.DataSource = dataGridView;
            }
        }
    }
}
