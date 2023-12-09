using ProjectProduct.Controllers.Presenters;
using ProjectProduct.Controllers.UI;
using ProjectProduct.Controllers.UI.Util;
using ProjectProduct.Models;
using ProjectProduct.Services;
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
            if (listProductSearch == null)
            {
                MessageBox.Show("Cannot find!", "Notification");
            }

            dataGridView = new BindingList<ProductDataGridView>(Common.convertListProductToDataGridViewPresenter(listProductSearch));
            dgProduct.DataSource = dataGridView;
        }

        //Key down
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
            string listSelectedString = "";
            listIndexSelectedRow.Clear();
            foreach (DataGridViewRow r in dgProduct.SelectedRows.Cast<DataGridViewRow>().Reverse())
            {
                listIndexSelectedRow.Add(r.Index);
                listSelectedString += r.Index.ToString();
                r.DefaultCellStyle.BackColor = Color.Yellow;
            }

            MessageBox.Show("List selected: " + listSelectedString);
            if (dgProduct.SelectedCells.Count > 0)
            {
                //Tiền xử lý dữ liệu
                System.Text.StringBuilder clipboardContent = new System.Text.StringBuilder();
                int currentRowIndex = -1;
                foreach (DataGridViewCell cell in dgProduct.SelectedCells)
                {
                    if (cell.RowIndex != currentRowIndex)
                    {
                        string id = dgProduct.Rows[cell.RowIndex].Cells[0].Value.ToString();
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
                clipboardContent.Length--;
                Clipboard.SetText(clipboardContent.ToString());
                MessageBox.Show("Copied Successfully", "Notification");
            }
        }

        private void pasteSelectedCellsToClipBoard()
        {
            //Message Box 
            MessageBoxButtons choiceButton = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to paste this content ?", "Question", choiceButton);
            if (result == DialogResult.Yes)
            {
                string clipboardContent = Clipboard.GetText();
                if (!string.IsNullOrEmpty(clipboardContent))
                {
                    string[] rows = clipboardContent.Split('\n');
                    int columnCount = dgProduct.Columns.Count;
                    List<int> listIndex = listIndexSelectedRow;
                    foreach (string rowText in rows)
                    {
                        string[] cells = rowText.Trim().Split("\t");
                        if (cells.Length == columnCount)
                        {
                            for(int i = 0; i < columnCount; i++)
                            {
                                dgProduct.Rows[listIndexSelectedRow[i]].Cells[i].Value = cells[i];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid data format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
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
    }
}
