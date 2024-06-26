﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mevp.Views;
using Supermarket_mevp._Repositories;
using Supermarket_mevp.Model;

namespace Supermarket_mevp.Presenter
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowProductView += ShowProductView;
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
         //   IPayModeView view =  new PayModeView.GetInstance((MainView)mainView);
         //   IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
          //  new PayModePresenter(view, repository); 
        }
    }
    
  

}

