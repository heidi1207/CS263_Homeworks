using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public abstract class Display : Form
    {
        public abstract void UpdateData(object sender, EventArgs e);
    }
}