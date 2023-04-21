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
    public partial class Broker : Form
    {
        public Broker()
        {
            InitializeComponent();
        }

        private void addProperty_Click(object sender, EventArgs e)
        {
            var addDialogue = new AddPropertyDialogue();
            addDialogue.ShowDialog();

        }

        private void propertyList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBroker_Click(object sender, EventArgs e)
        {
            var loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }
    }
}
