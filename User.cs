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
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class User : Form
    {
        JObject userData;
        public User(JObject userData)
        {
            InitializeComponent();

            this.userData = userData;
            this.label1.Text += userData.GetValue("name").ToString();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            Text = "Dashboard";

            dbHandler db = new dbHandler();
            flowLayoutPanel1.Controls.Clear();
            db.populateListing(this.flowLayoutPanel1, userData);

            flowLayoutPanel2.Controls.Clear();
            foreach (JObject item in db.getOwnedProperty(userData))
            {
                // MessageBox.Show(item.ToString());
                flowLayoutPanel2.Controls.Add(new dashboard(item));
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var profilepage = new Profile(userData);
            profilepage.Show();

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            var paymentpage = new Payment(userData);
            paymentpage.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /* BackColor = ColorTranslator.FromHtml("#121212");
             this.ForeColor = Color.White;
 */
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var contact = new ContactUs();
            contact.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            var market = new Market(userData);
            market.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.User_Load(sender, e);
        }
    }
}
