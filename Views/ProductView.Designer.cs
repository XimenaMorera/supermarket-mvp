namespace Supermarket_mevp.Views
{
    partial class ProductView
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
            label1 = new Label();
            DgProductMode = new DataGridView();
            label2 = new Label();
            txtSearchProduct = new TextBox();
            BtnSearchProduct = new Button();
            BtnAddProduct = new Button();
            BtnEditProduct = new Button();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DgProductMode).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 53);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            label1.Click += label1_Click;
            // 
            // DgProductMode
            // 
            DgProductMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProductMode.Location = new Point(151, 151);
            DgProductMode.Name = "DgProductMode";
            DgProductMode.Size = new Size(240, 150);
            DgProductMode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 88);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Search Product";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(151, 106);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.PlaceholderText = "Product Search";
            txtSearchProduct.Size = new Size(240, 23);
            txtSearchProduct.TabIndex = 3;
            // 
            // BtnSearchProduct
            // 
            BtnSearchProduct.Location = new Point(467, 133);
            BtnSearchProduct.Name = "BtnSearchProduct";
            BtnSearchProduct.Size = new Size(75, 23);
            BtnSearchProduct.TabIndex = 4;
            BtnSearchProduct.Text = "Search";
            BtnSearchProduct.UseVisualStyleBackColor = true;
            BtnSearchProduct.Click += BtnSearchProduct_Click;
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Location = new Point(467, 173);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(75, 23);
            BtnAddProduct.TabIndex = 5;
            BtnAddProduct.Text = "Adicionar Producto";
            BtnAddProduct.UseVisualStyleBackColor = true;
            // 
            // BtnEditProduct
            // 
            BtnEditProduct.Location = new Point(467, 218);
            BtnEditProduct.Name = "BtnEditProduct";
            BtnEditProduct.Size = new Size(75, 23);
            BtnEditProduct.TabIndex = 6;
            BtnEditProduct.Text = "Edit";
            BtnEditProduct.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(467, 265);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEditProduct);
            Controls.Add(BtnAddProduct);
            Controls.Add(BtnSearchProduct);
            Controls.Add(txtSearchProduct);
            Controls.Add(label2);
            Controls.Add(DgProductMode);
            Controls.Add(label1);
            Name = "ProductView";
            ((System.ComponentModel.ISupportInitialize)DgProductMode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DgProductMode;
        private Label label2;
        private TextBox txtSearchProduct;
        private Button BtnSearchProduct;
        private Button BtnAddProduct;
        private Button BtnEditProduct;
        private Button BtnDelete;
    }
}