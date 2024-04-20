using Supermarket_mevp.Model;
using Supermarket_mevp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mevp.Presenter
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductModel> productsList;
        public ProductPresenter(IProductView view, IProductRepository repository)
    }
}
