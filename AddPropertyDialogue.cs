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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AddPropertyDialogue : Form
    {
        string types = null;
        public AddPropertyDialogue()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbHandler db = new dbHandler();
            JObject jobj = new JObject();
            // `name`, `address`, `value`, `image`, `status`
            jobj.Add("name", t1.Text);
            jobj.Add("address", t2.Text);
            jobj.Add("value", t3.Text);
            jobj.Add("type", types);
            jobj.Add("image", "under devlopment");
            /*jobj.Add("status", "under devlopment");*/

            if (db.insertProperty(jobj) == -1)
            {
                MessageBox.Show("cannot insert right now");
            }
            else
            {
                var listingpage = new Listing(t1.Text, t2.Text, t3.Text, types);
                Broker.propertyList.Controls.Add(listingpage);
                this.Hide();
            }


        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                Bitmap i = new Bitmap(open.FileName);
                i = new Bitmap(i, new Size(110, 87));
                pictureBox1.Image = i;
                //MessageBox.Show(open.FileName);
                string filename = "/Media" + t1.Text + t2.Text;
                FileStream fstream = new FileStream(filename, FileMode.Create);

                i.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            types = type.SelectedItem.ToString();
        }
    }
}
