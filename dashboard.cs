using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class dashboard : UserControl
    {
        private JObject data;
        public dashboard(JObject data)
        {
            this.data = data;
           
            InitializeComponent();
            //data.Add("id", rd.GetValue(0).ToString());
            //data.Add("name", rd.GetValue(1).ToString());
            //data.Add("address", rd.GetValue(2).ToString());
            //data.Add("value", rd.GetValue(3).ToString());
            //data.Add("image", rd.GetValue(4).ToString());
            //data.Add("type", rd.GetValue(5).ToString());
            this.propertyName.Text = data.GetValue("name").ToString();
            this.textBox1.Text = data.GetValue("address").ToString();
            this.textBox2.Text = data.GetValue("value").ToString();
            this.textBox3.Text = data.GetValue("type").ToString();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            var paymentpage = new Payment(data);
            paymentpage.Show();
        }
    }
}
