﻿using ProjectProduct.Controllers.Presenters.ListProduct;
using ProjectProduct.Controllers.UI;
using ProjectProduct.Controllers.UI.Util;
using ProjectProduct.Models;
using ProjectProduct.Services.Products;
using System.ComponentModel;

namespace ProjectProduct
{
    public partial class Form1 : Form
    {
        private ProductUseCase service;

        BindingList<ProductDataGridView> dataGridView = new BindingList<ProductDataGridView>();
        private List<int> listIndexSelectedRow = new List<int>();
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
            dgProduct.KeyDown += DataGridViewKeyDown;
        }

        private void InItDataGridView()
        {
            //Hiden ID Col
            List<Product> products = service.GetAll();
            dataGridView = new BindingList<ProductDataGridView>(Common.convertListProductToDataGridViewPresenter(products));
            dgProduct.DataSource = dataGridView;
            //Hiden Id fields
            dgProduct.Columns[0].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Product> listProductSearch = service.GetListProductByName(tbSearch.Text);
            dataGridView = new BindingList<ProductDataGridView>(Common.convertListProductToDataGridViewPresenter(listProductSearch));
            dgProduct.DataSource = dataGridView;
        }

        //Key down
        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Product> listProductSearch = service.GetListProductByName(tbSearch.Text);
                dataGridView = new BindingList<ProductDataGridView>(Common.convertListProductToDataGridViewPresenter(listProductSearch));
                dgProduct.DataSource = dataGridView;
            }
        }

        private void DataGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                //Cancel action copy of Windows
                e.Handled = true;
                e.SuppressKeyPress = true;
                //Reset column previous copy
                Helper.ResetRowColorDatagridView(dgProduct);
                copySelectedCellsToClipBoard();
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                pasteSelectedCellsToClipBoard();
            }
        }

        //Action Copy
        private void copySelectedCellsToClipBoard()
        {
            listIndexSelectedRow.Clear();
            foreach (DataGridViewRow r in dgProduct.SelectedRows.Cast<DataGridViewRow>().Reverse())
            {
                listIndexSelectedRow.Add(r.Index);
                r.DefaultCellStyle.BackColor = Color.Yellow;
            }

            if (dgProduct.SelectedRows.Count > 0)
            {
                //Tiền xử lý dữ liệu
                System.Text.StringBuilder clipboardContent = new System.Text.StringBuilder();
                foreach(DataGridViewRow row in dgProduct.SelectedRows)
                {
                    int currentRowIndex = -1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.RowIndex != currentRowIndex)
                        {
                            // This is a new row, add a newline to separate from the previous row
                            if (currentRowIndex != -1)
                            {
                                clipboardContent.AppendLine();
                            }

                            currentRowIndex = cell.RowIndex;
                        }
                        else
                        {
                            // This is the same row, add a tab to separate from the previous cell in the same row
                            clipboardContent.Append('\t');
                        }

                        // Append cell value or an empty string if the cell value is null
                        clipboardContent.Append(cell.Value?.ToString() ?? string.Empty);
                    }
                }
                Clipboard.SetText(clipboardContent.ToString());
            }
        }

        private void pasteSelectedCellsToClipBoard()
        {
            //Message Box 
            DialogResult result = Helper.ShowYesNoQuestion("Do you want to paste them into Datagrid View?");
            if (result == DialogResult.Yes)
            {
                string clipboardContent = Clipboard.GetText();
                if (!string.IsNullOrEmpty(clipboardContent))
                {
                    string[] rows = clipboardContent.Split('\n');
                    int columnCount = dgProduct.Columns.Count;
                    List<int> listIndex = listIndexSelectedRow;
                    int index = 0;
                    foreach (string rowText in rows)
                    {
                        string[] cells = rowText.Trim().Split("\t");
                        if (cells.Length == columnCount)
                        {
                            for (int i = 0; i < columnCount; i++)
                            {
                                dgProduct.Rows[listIndexSelectedRow[index]].Cells[i].Value = cells[i];
                            }
                        }
                        else
                        {
                            Helper.ShowErrorMessage("Invalid data format.");
                            break;
                        }
                        index++;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            /*
            
            (sender as DataGridView).CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            (sender as DataGridView).CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Black;
            
        
         */
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgProduct.SelectedRows.Count <= 0)
            {
                Helper.ShowErrorMessage("Cannot find selected row");
                return;
            } else if (dgProduct.SelectedRows.Count > 1)
            {
                Helper.ShowErrorMessage("You can only select one row in grid");
                return;
            } else
            {
                //Get Product Id from Seletec Row
                string productId = dgProduct.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
                decimal productIdDecimal;
                if (!decimal.TryParse(productId, out productIdDecimal))
                {
                    Helper.ShowErrorMessage("Failed to Parse ID's Product");
                }
                ProductDetail productDetailScreen = new ProductDetail(service, productIdDecimal);
                productDetailScreen.Show();
            }

        }
    }
}
