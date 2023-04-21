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
    public partial class Profile : Form
    {
        JObject userData;
        public Profile(JObject userData)
        {
            InitializeComponent();
            this.userData = userData;
            this.profileName.Text = userData.GetValue("name").ToString();
            this.profileEmail.Text = userData.GetValue("email").ToString();
            this.profilePassword.Text = userData.GetValue("password").ToString();
            this.profilePhone.Text = userData.GetValue("mobile").ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var dashboard = new User(userData);
            //dashboard.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void profileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
