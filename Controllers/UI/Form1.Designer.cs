namespace ProjectProduct
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tbSearch = new TextBox();
            label1 = new Label();
            dgProduct = new DataGridView();
            btnSearch = new Button();
            btnViewDetail = new Button();
            btnAdd = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.Location = new Point(178, 39);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(283, 29);
            tbSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 41);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // dgProduct
            // 
            dgProduct.AllowDrop = true;
            dgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(41, 199);
            dgProduct.Name = "dgProduct";
            dgProduct.RowTemplate.Height = 30;
            dgProduct.Size = new Size(794, 267);
            dgProduct.TabIndex = 2;
            dgProduct.CellContentClick += dgProduct_CellContentClick;
            dgProduct.SelectionChanged += dgProduct_SelectionChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(646, 104);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(180, 52);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewDetail.Location = new Point(41, 498);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(180, 52);
            btnViewDetail.TabIndex = 4;
            btnViewDetail.Text = "View Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(281, 498);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 52);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "New Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(655, 498);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 52);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 562);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(btnViewDetail);
            Controls.Add(btnSearch);
            Controls.Add(dgProduct);
            Controls.Add(label1);
            Controls.Add(tbSearch);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearch;
        private Label label1;
        private DataGridView dgProduct;
        private Button btnSearch;
        private Button btnViewDetail;
        private Button btnAdd;
        private Button btnClose;
    }
}
