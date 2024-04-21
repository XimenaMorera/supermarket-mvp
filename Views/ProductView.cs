using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mevp.Views
{
    public partial class ProductView : Form, IProductView
    {
        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        string IProductView.ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public string ProductPrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductCatId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue 
        {
            get { return txtSearchProduct.Text; }
            set { txtSearchProduct.Text = value; }
        }
        public bool IsEdit {
            get { return IsEdit; }
            set { IsEdit = value; }
        }
        public bool IsSuccessful {
            get { return IsSuccessful; }
            set { IsSuccessful = value; }
        }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabProductDetail);

            BtnSearchProduct.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Boton Nuevo, llamado a AddNewEvent cuando hay click en BtnNew
            BtnAddProduct.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                txtSearchProduct.Focus();
                txtSearchProduct.DeselectAll();
                tabProductList.Text = "Add new Product";
            };
            BtnEditProduct.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                txtSearchProduct.Focus();
                txtSearchProduct.DeselectAll();
                tabProductDetail.Text = "Edit new Products";
            };
            
           
            BtnDelete.Click += delegate
            {
                var Result = MessageBox.Show(
                    "Info. Are you sure you want to delete the selected Pay Mode",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchProduct.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            txtSearchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnAddProduct.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                tabProductDetail.Text = "Add New Product";
            };
            BtnEditProduct.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabProductList);
                tabControl1.TabPages.Add(tabProductDetail);
                tabProductDetail.Text = "Edit Product";
            };
            BtnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabProductDetail);
                    tabControl1.TabPages.Add(tabProductList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProductDetail);
                tabControl1.TabPages.Add(tabProductList);

            };
            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected Product", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchProduct_Click(object sender, EventArgs e)
        {

        }

        public void SetProductsListBildingSource(BindingSource productsList)
        {
           DgProductMode.DataSource = productsList;
        }
        private static ProductView instance;

        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
