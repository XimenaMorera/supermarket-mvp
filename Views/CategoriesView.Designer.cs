namespace Supermarket_mevp.Views
{
    partial class CategoriesView
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
            panel1 = new Panel();
            lblCategories = new Label();
            tabControl1 = new TabControl();
            tabPageCategoriesList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEditar = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            DgCategories = new DataGridView();
            tabPageCategoriasDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            txtCategoriesObservation = new TextBox();
            TxtCategoriesName = new TextBox();
            TxtCategoriesId = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabPageCategoriasDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCategories);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 0;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(93, 9);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(63, 15);
            lblCategories.TabIndex = 0;
            lblCategories.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriasDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 404);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(BtnClose);
            tabPageCategoriesList.Controls.Add(BtnDelete);
            tabPageCategoriesList.Controls.Add(BtnEditar);
            tabPageCategoriesList.Controls.Add(BtnNew);
            tabPageCategoriesList.Controls.Add(BtnSearch);
            tabPageCategoriesList.Controls.Add(TxtSearch);
            tabPageCategoriesList.Controls.Add(DgCategories);
            tabPageCategoriesList.Location = new Point(4, 24);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 376);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(453, 209);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 23);
            BtnClose.TabIndex = 6;
            BtnClose.Text = "Cerrar";
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(439, 152);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 5;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(433, 112);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(75, 23);
            BtnEditar.TabIndex = 4;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Location = new Point(433, 68);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(75, 23);
            BtnNew.TabIndex = 3;
            BtnNew.Text = "New";
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(433, 17);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "button1";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(24, 17);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(357, 23);
            TxtSearch.TabIndex = 1;
            // 
            // DgCategories
            // 
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(24, 46);
            DgCategories.Name = "DgCategories";
            DgCategories.Size = new Size(353, 185);
            DgCategories.TabIndex = 0;
            // 
            // tabPageCategoriasDetail
            // 
            tabPageCategoriasDetail.Controls.Add(BtnCancel);
            tabPageCategoriasDetail.Controls.Add(BtnSave);
            tabPageCategoriasDetail.Controls.Add(txtCategoriesObservation);
            tabPageCategoriasDetail.Controls.Add(TxtCategoriesName);
            tabPageCategoriasDetail.Controls.Add(TxtCategoriesId);
            tabPageCategoriasDetail.Location = new Point(4, 24);
            tabPageCategoriasDetail.Name = "tabPageCategoriasDetail";
            tabPageCategoriasDetail.Padding = new Padding(3);
            tabPageCategoriasDetail.Size = new Size(792, 376);
            tabPageCategoriasDetail.TabIndex = 1;
            tabPageCategoriasDetail.Text = "Cateories Detail";
            tabPageCategoriasDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(278, 102);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 4;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(278, 51);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // txtCategoriesObservation
            // 
            txtCategoriesObservation.Location = new Point(52, 155);
            txtCategoriesObservation.Name = "txtCategoriesObservation";
            txtCategoriesObservation.Size = new Size(100, 23);
            txtCategoriesObservation.TabIndex = 2;
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Location = new Point(48, 103);
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.Size = new Size(100, 23);
            TxtCategoriesName.TabIndex = 1;
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(48, 30);
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.Size = new Size(100, 23);
            TxtCategoriesId.TabIndex = 0;
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            Load += CategoriesView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabPageCategoriasDetail.ResumeLayout(false);
            tabPageCategoriasDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCategories;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TextBox TxtSearch;
        private DataGridView DgCategories;
        private TabPage tabPageCategoriasDetail;
        private Button BtnSearch;
        private Button BtnEditar;
        private Button BtnNew;
        private TextBox txtCategoriesObservation;
        private TextBox TxtCategoriesName;
        private TextBox TxtCategoriesId;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnCancel;
        private Button BtnSave;
    }
}