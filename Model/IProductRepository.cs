using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mevp.Model
{
    internal interface IProductRepository
    {
        void Add(ProductModel productsModel);
        void Edit(ProductModel productsModel);
        void Delete(int id);
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value);
    }
}
