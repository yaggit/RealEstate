using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=realestate;";
        MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailfield.Text) && string.IsNullOrEmpty(passwordfield.Text))
            {
                MessageBox.Show("Please enter Email/Password!");
                emailfield.Focus();

            }
            else
            {
               


                if (this.emailfield.Text == "admin" && this.passwordfield.Text == "admin")
                {
                    var brokerpage = new Broker();
                    this.Hide();
                    brokerpage.Show();
                }
                else
                {


                    connection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM user WHERE email = '" + emailfield.Text + "' AND password = '" + passwordfield.Text + "'", connection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    if (mySqlDataReader.Read())
                    {
                        // MessageBox.Show(mySqlDataReader.GetValue(1).ToString());

                        JObject userData = new JObject();
                        userData.Add("name", mySqlDataReader.GetValue(1).ToString());
                        userData.Add("email", mySqlDataReader.GetValue(2).ToString());
                        userData.Add("password", mySqlDataReader.GetValue(3).ToString());
                        userData.Add("mobile", mySqlDataReader.GetValue(4).ToString());



                        var userpage = new User(userData); 
                        MessageBox.Show("Welcome!");
                        userpage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Sign In!");
                    }
                    connection.Close();

                }
            }




          


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void emailfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void signinlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var siginin = new SignIn();
            siginin.Show();
            this.Hide();
        }

        private void passwordfield_TextChanged(object sender, EventArgs e)
        {
            passwordfield.PasswordChar = '●';
        }
    }
}