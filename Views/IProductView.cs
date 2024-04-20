using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mevp.Views
{
    internal interface IProductView
    {
        string PayModeId { get; set; }
        string PayModeName { get; set; }
    }
}
