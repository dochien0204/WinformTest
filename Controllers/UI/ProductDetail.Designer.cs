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
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbProductName);
            Controls.Add(tbProductId);
            Name = "ProductDetail";
            Text = "ProductDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProductId;
        private TextBox tbProductName;
        private Label label1;
        private Label label2;
    }
}