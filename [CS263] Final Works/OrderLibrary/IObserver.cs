using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary
{
    public interface IObserver
    {
        //args 就是事件的參數 , 就是 OrderData
        void UpdateDate(object sender, EventArgs args);
    }
}