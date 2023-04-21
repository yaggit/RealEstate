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
    public partial class Market : Form
    {
        JObject udata;
        public Market(JObject userData)
        {
            this.udata = userData;
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Market_Load(object sender, EventArgs e)
        {
            dbHandler db = new dbHandler();
            db.populateListing(flowLayoutPanel1,udata);
        }
    }
}
