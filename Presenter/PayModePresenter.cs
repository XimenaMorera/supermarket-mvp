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
            view.IsEdit = false;

        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindigSource.DataSource = payModeList;
        }

        private void loadAllPayModeToEdit(object? sender, EventArgs e)
        {
            var payMode = (PayModeModel)payModeBindigSource.Current;
            payModeList = repository.GetAll();
            view.PayModeId=payMode.Id.ToString();
            view.PayModeName = payMode.Name();
            view.PayModeObservation=payMode.Observation;
            view.IsEdit=true;


        }
        private void CancelAction(object? sender, EventArgs e)
        {
           CleanViewFields();
         }
        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try

            {
                new Common.ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode edited succesfuly";

                }
                else
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode edited succesfly";
                }
                view.IsSuccessful = true;
                loadAllPayModeList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields() {
            view.PayModeId = "0";
            view.PayModeName = "0";
            view.PayModeObservation = "0";
        }
        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                //Se recupera el objeto de la fila seleccionada del dataviewgird
                var payMode = (PayModeModel)payModeBindigSource.Current;

                //Se invoca el metodo Delete del repositorio pasandole el id del Pay Mode 
                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode deleted successfully";
                loadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pay mode";
            }
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

