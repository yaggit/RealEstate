using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SignIn : Form
    {
        MySqlConnection databaseConnection;
        public SignIn()
        {
            InitializeComponent();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=realestate;";


            databaseConnection = new MySqlConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sigin_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#212121");
            this.ForeColor = Color.White;

        }

        private void loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }

        private void signincheck_CheckedChanged(object sender, EventArgs e)
        {

            /*   if (signincheck.Checked == false)
               {
                   MessageBox.Show("Accept Terms & Conditions and Privacy Policy!");
               }
            */
            //signincheck.Checked = true;
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[0-9]{9}"))
            {
                MessageBox.Show("Only 10 numbers are allowed!");

            }
            else
            {
                databaseConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO user(`name`, `email`, `password`, `mobile`, `dob`) VALUES ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "')", databaseConnection);


                /* mySqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
                mySqlCommand.Parameters.AddWithValue("@email", textBox3.Text);
                mySqlCommand.Parameters.AddWithValue("@password", textBox4.Text);
                mySqlCommand.Parameters.AddWithValue("@mobile", textBox2.Text);
                mySqlCommand.Parameters.AddWithValue("@dob", dateTimePicker1.Text);
                mySqlCommand.Prepare();*/

                int x = mySqlCommand.ExecuteNonQuery();
                databaseConnection.Close();

                if (x == 0)
                {
                    MessageBox.Show("Error!");
                }
                else if (signincheck.Checked == false)
                {
                    MessageBox.Show("Accept Terms & Conditions and Privacy Policy!");
                }
                else
                {
                    MessageBox.Show("Registered Successfully!");
                    JObject userData = new JObject();
                    userData.Add("name", textBox1.Text);
                    userData.Add("email", textBox3.Text);
                    userData.Add("password", textBox4.Text);
                    userData.Add("mobile", textBox2.Text);

                    var userpage = new User(userData);
                    userpage.Show();
                    this.Hide();
                }

            }

        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //    if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z]"))
        //    {
        //        MessageBox.Show("Only alphabetes are allowed!");

        //    }

        //}

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '●';

            Control.IsKeyLocked(Keys.CapsLock);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tandc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var policypage = new policy();
            policypage.Show();
            this.Hide();
        }

        private void privacy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var policypage = new policy();
            policypage.Show();
            this.Hide();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    /*      if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
        //          {
        //              e.Handled = true;
        //          }

        //          if (textBox1.Text.Length >= 10 && e.KeyChar != '\b')
        //          {
        //              e.Handled = true;
        //          }*/

        //    /*Regex re = new Regex("[0-9]{9}");

        //    if (re.IsMatch(textBox2.Text.Trim()) == false || textBox2.Text.Length > 10)
        //    {
        //        MessageBox.Show("Invalid Indian Mobile Number!!");
        //        textBox2.Focus();
        //    }*/
        //}
    }
}
