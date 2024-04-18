using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mevp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private bool message;

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageModeDetail);
            BtnClose.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNew.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageModeList);
                tabControl1.TabPages.Add(tabPageModeDetail);
                tabPageModeDetail.Text= "Add New Pay Mode";

            };
            BtnEdit.Click += delegate
            { EditEvent?.Invoke(this, EventArgs.Empty);
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageModeList);
                tabControl1.TabPages.Add(tabPageModeDetail);
                tabPageModeDetail.Text = "Edit Pay Mode";
            };
            BtnDelete.Click += delegate { 
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                {
                   var result = MessageBox.Show(
                       "Are you sure you want Delete the Sected Pay Mode",
                       "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(result == DialogResult.Yes)
                    {
                        DeleteEvent?.Invoke(this,EventArgs.Empty);
                        MessageBox.Show(Message);
                    }

                }

            };
            BtnSave.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty); 
                if (isSuccessful)
                {
                    tabControl1.TabPages.Add(tabPageModeDetail);
                    tabControl1.TabPages.Add(tabPageModeList);

                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tabPageModeDetail);
                tabControl1.TabPages.Add(tabPageModeList);
            };
        }

        //  public string PayModeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //   public string PayModeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //  public string PayModeObservation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //    public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //  public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //  public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void setPayModeListBilidngSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }

        private static PayModeView? instance;

        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle=FormBorderStyle.None;
                instance.Dock= DockStyle.Fill;
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
    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }

        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }

        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { IsEdit = value; }
        }

        public bool IsSuccesful
        {
            get { return IsSuccesful; }
            set { IsSuccesful = value; }
        }
        public string Message
        {
            get { return Message; }
            set { Message = value; }
        }

    }

}

