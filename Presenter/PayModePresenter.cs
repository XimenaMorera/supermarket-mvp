using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mevp.Views;
using Supermarket_mevp.Model;
using System.ComponentModel;

namespace Supermarket_mevp.Presenter
{
    internal class PayModePresenter
    {
        private IPayModeView view;

        private IPayModeRepository repository;



        private BindingSource payModeBindigSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindigSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModetoEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;
          //  this.view.setPayModeListBilidngSource(payModeBindingSource);

            loadAllPayModeList();
            this.view.Show();


        }

        private void LoadSelectPayModetoEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindigSource.DataSource = payModeList;
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
         }
        private void SavePayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
         }
        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
         }
        private void LoadSelectedPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
         }
        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList= repository.GetAll();
            }
            payModeBindigSource.DataSource = payModeList;
        }
    }
}

