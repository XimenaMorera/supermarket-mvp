using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mevp.Views
{
    internal interface IPayModeView
    {
        string PayModeId { get; set; }
        string PayModeName { get; set; }
        string PayModeObservation{ get; set; }

        string SearchValue {  get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful {  get; set; }
        string Message {  get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditNewEvent;
        event EventHandler DeleteNewEvent;
        event EventHandler SaveNewEvent;
        event EventHandler CancelNewEvent;

        void setPayModeListBilidngSource(BindingSource payModeList);
        void Show();


    }
}
