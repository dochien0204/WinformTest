using ProjectProduct.Models;
using System.Windows.Forms;

namespace ProjectProduct.Controllers.UI
{
    partial class ProductDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbProductId = new TextBox();
            tbProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgComponent = new DataGridView();
            btnCopy = new Button();
            btnPaste = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgComponent).BeginInit();
            SuspendLayout();
            // 
            // tbProductId
            // 
            tbProductId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductId.Location = new Point(175, 42);
            tbProductId.Name = "tbProductId";
            tbProductId.Size = new Size(283, 29);
            tbProductId.TabIndex = 1;
            // 
            // tbProductName
            // 
            tbProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductName.Location = new Point(175, 100);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(283, 29);
            tbProductName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 108);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 3;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 50);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // dgComponent
            // 
            dgComponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgComponent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgComponent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dgComponent.Location = new Point(59, 187);
            dgComponent.Name = "dgComponent";
            dgComponent.RowTemplate.Height = 25;
            dgComponent.Size = new Size(727, 257);
            dgComponent.TabIndex = 5;
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopy.Location = new Point(59, 486);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(150, 41);
            btnCopy.TabIndex = 6;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnPaste
            // 
            btnPaste.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaste.Location = new Point(241, 486);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(150, 41);
            btnPaste.TabIndex = 7;
            btnPaste.Text = "Paste";
            btnPaste.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(431, 486);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 41);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(615, 486);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 41);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 554);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnPaste);
            Controls.Add(btnCopy);
            Controls.Add(dgComponent);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbProductName);
            Controls.Add(tbProductId);
            Name = "ProductDetail";
            Text = "ProductDetail";
            ((System.ComponentModel.ISupportInitialize)dgComponent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProductId;
        private TextBox tbProductName;
        private Label label1;
        private Label label2;
        private DataGridView dgComponent;
        private Button btnCopy;
        private Button btnPaste;
        private Button btnUpdate;
        private Button btnClose;
    }
}