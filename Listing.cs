﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Listing : UserControl
    {
        public Listing(string name, string address, string value, string type)
        {
            InitializeComponent();
            this.nameText.Text = name;
            this.addressText.Text = address;
            this.valueText.Text = value;
            this.textBox1.Text = type;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Listing_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
