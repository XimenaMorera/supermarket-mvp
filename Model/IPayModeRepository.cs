using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mevp.Model
{
    internal interface IPayModeRepository
    {
        void Add(PayModeModel payModeModel);
        void Edit(PayModeModel payModeModel);
        void Delete(int Id);

        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> GetbyValue(string Value);
    }
}
