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
    public partial class marketCard : UserControl
    {
        public int id;
        public string uemail=null,upass=null;
        public marketCard(JObject data,JObject userdata)
        {
            InitializeComponent();
          //  MessageBox.Show(data.ToString());
            this.id = int.Parse(data.GetValue("id").ToString());
            this.uemail = userdata.GetValue("name").ToString();
            this.upass = userdata.GetValue("password").ToString();
            //data.Add("id", rd.GetValue(0).ToString());
            //data.Add("name", rd.GetValue(1).ToString());
            //data.Add("address", rd.GetValue(2).ToString());
            //data.Add("value", rd.GetValue(3).ToString());
            //data.Add("image", rd.GetValue(4).ToString());
            //data.Add("status", rd.GetValue(5).ToString());

            this.nameText.Text = data.GetValue("name").ToString();
            this.addressText.Text = data.GetValue("address").ToString();
            this.valueText.Text = data.GetValue("value").ToString();
            this.textBox1.Text = data.GetValue("type").ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbHandler d = new dbHandler();
            if (d.buyproperty(this)==-1)
            {
                MessageBox.Show("Try again later!");
            }
            else
            {   /*var paymentpage = new Payment(userData);
                paymentpage.Show();*/

                MessageBox.Show("Property added.");
            }
          
        }
    }
}
