﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HueraEcologica_SID
{
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form29 form29 = new Form29();
            this.Hide();
            form29.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            this.Hide();
            form25.ShowDialog();
            this.Close();
        }

        private void Form28_Load(object sender, EventArgs e)
        {

        }
    }
}
