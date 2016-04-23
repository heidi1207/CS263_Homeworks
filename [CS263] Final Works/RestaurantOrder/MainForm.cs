using OrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrder
{
    public partial class MainForm : Form, ISubject, IObserver
    {
        private List<IObserver> observers;
        private OrderData orderData;

        public MainForm()
        {
            InitializeComponent();
            observers = new List<IObserver>();
            this.orderData = new OrderData();
            this.RegisterObserver(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (IObserver o in observers)
            {
                if (o is Form)
                {
                    Form form = o as Form;
                    form.Show();
                }
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text += string.Format("桌號: {0} , 點餐: {1} , 數量: {2} \n"
                , tableComboBox.SelectedItem.ToString()
                , mealComboBox.SelectedItem.ToString()
                , mealCountTextBox.Text);
            tableComboBox.Text = null;
            mealComboBox.Text = null;
            mealCountTextBox.Text = null;
            string result = resultRichTextBox.Text;
            OrderData orderData = new OrderData() { Result = result };
            this.MeasurementsChanged(orderData);
        }

        public void UpdateDate(object sender, EventArgs args)
        {
            //args 型別是 EventArgs , 所以要用 as 轉型別
            OrderData data = args as OrderData;
            resultRichTextBox.Text = data.Result.ToString();
        }

        public void RegisterObserver(IObserver o)
        {
            //註冊 IObserver
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            //不要顯示時 , 可以移除
            observers.Remove(o);
        }

        public void MeasurementsChanged(OrderData data)
        {
            if (data.Result != this.orderData.Result)
            {
                this.orderData = data;
                //資料變了就要通知
                Notify();
            }
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
                o.UpdateDate(this, this.orderData);
        }
    }
}