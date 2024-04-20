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
            tabControl1 = new TabControl();
            tabProductList = new TabPage();
            tabProductDetail = new TabPage();
            panel1 = new Panel();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)DgProductMode).BeginInit();
            tabControl1.SuspendLayout();
            tabProductList.SuspendLayout();
            tabProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 23);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            label1.Click += label1_Click;
            // 
            // DgProductMode
            // 
            DgProductMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProductMode.Location = new Point(50, 91);
            DgProductMode.Name = "DgProductMode";
            DgProductMode.Size = new Size(240, 150);
            DgProductMode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 23);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Search Product";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(50, 53);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.PlaceholderText = "Product Search";
            txtSearchProduct.Size = new Size(240, 23);
            txtSearchProduct.TabIndex = 3;
            // 
            // BtnSearchProduct
            // 
            BtnSearchProduct.Location = new Point(436, 52);
            BtnSearchProduct.Name = "BtnSearchProduct";
            BtnSearchProduct.Size = new Size(75, 23);
            BtnSearchProduct.TabIndex = 4;
            BtnSearchProduct.Text = "Search";
            BtnSearchProduct.UseVisualStyleBackColor = true;
            BtnSearchProduct.Click += BtnSearchProduct_Click;
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Location = new Point(436, 106);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(75, 23);
            BtnAddProduct.TabIndex = 5;
            BtnAddProduct.Text = "Adicionar Producto";
            BtnAddProduct.UseVisualStyleBackColor = true;
            // 
            // BtnEditProduct
            // 
            BtnEditProduct.Location = new Point(436, 150);
            BtnEditProduct.Name = "BtnEditProduct";
            BtnEditProduct.Size = new Size(75, 23);
            BtnEditProduct.TabIndex = 6;
            BtnEditProduct.Text = "Edit";
            BtnEditProduct.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(436, 200);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProductList);
            tabControl1.Controls.Add(tabProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 73);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 377);
            tabControl1.TabIndex = 8;
            // 
            // tabProductList
            // 
            tabProductList.Controls.Add(BtnDelete);
            tabProductList.Controls.Add(DgProductMode);
            tabProductList.Controls.Add(BtnEditProduct);
            tabProductList.Controls.Add(txtSearchProduct);
            tabProductList.Controls.Add(BtnAddProduct);
            tabProductList.Controls.Add(label2);
            tabProductList.Controls.Add(BtnSearchProduct);
            tabProductList.Location = new Point(4, 24);
            tabProductList.Name = "tabProductList";
            tabProductList.Padding = new Padding(3);
            tabProductList.Size = new Size(792, 349);
            tabProductList.TabIndex = 0;
            tabProductList.Text = "Product List";
            tabProductList.UseVisualStyleBackColor = true;
            // 
            // tabProductDetail
            // 
            tabProductDetail.Controls.Add(BtnCancel);
            tabProductDetail.Controls.Add(BtnSave);
            tabProductDetail.Controls.Add(TxtProductName);
            tabProductDetail.Controls.Add(TxtProductId);
            tabProductDetail.Location = new Point(4, 24);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.Padding = new Padding(3);
            tabProductDetail.Size = new Size(792, 349);
            tabProductDetail.TabIndex = 1;
            tabProductDetail.Text = "Product Detail";
            tabProductDetail.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 73);
            panel1.TabIndex = 9;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(37, 35);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(100, 23);
            TxtProductId.TabIndex = 0;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(40, 86);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(100, 23);
            TxtProductName.TabIndex = 1;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(69, 170);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "BtnSave";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(198, 170);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "btnCancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            ((System.ComponentModel.ISupportInitialize)DgProductMode).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductList.ResumeLayout(false);
            tabProductList.PerformLayout();
            tabProductDetail.ResumeLayout(false);
            tabProductDetail.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage tabProductDetail;
        private TabPage tabProductList;
        private Panel panel1;
        private TextBox TxtProductId;
        private TextBox TxtProductName;
        private Button BtnCancel;
        private Button BtnSave;
    }
}