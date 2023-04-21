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
    public partial class Payment : Form
    {
        JObject userData;
        public Payment(JObject userData)
        {
            InitializeComponent();
            this.textBox1.Text = userData.GetValue("name").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Successful!");
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.PasswordChar = '●';
            textBox7.MaxLength = 16;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*Random random = new Random();
            int randomNumber = random.Next(100000, 999999); // generate a random number between 100000 and 999999
            textBox3.Text = randomNumber.ToString();*/
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 999999);
            this.textBox3.Text = "$"+(randomNumber);
            randomNumber = random.Next(000,999);
            this.textBox4.Text = "$" + (randomNumber);
            randomNumber = random.Next(000, 999);
            this.textBox5.Text = "$" + (randomNumber);
        }
    }
}
