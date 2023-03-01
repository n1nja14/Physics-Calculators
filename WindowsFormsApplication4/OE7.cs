﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class OE7 : Form
    {
        public OE7()
        {
            InitializeComponent();
        }
        public static OE7 Instance;
        public static OE7 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE7();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OE6 f = OE6.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                OE1.Data.p += 1;
            }
            OE8 f = OE8.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}