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
    public partial class policy : Form
    {
        public policy()
        {
            InitializeComponent();
        }

        private void policy_Load(object sender, EventArgs e)
        {
            Text = "Policy";
        }

        private void close_Click(object sender, EventArgs e)
        {
            var close = new SignIn();
            close.Show();
            this.Hide();
        }
    }
}
