using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderLibrary
{
    public partial class KitchenDisplay : Form, IObserver
    {
        public KitchenDisplay()
        {
            InitializeComponent();
        }

        public void UpdateDate(object sender, EventArgs args)
        {
            //args 型別是 EventArgs , 所以要用 as 轉型別
            OrderData data = args as OrderData;
            resultRichTextBox.Text = data.Result.ToString();
        }
    }
}