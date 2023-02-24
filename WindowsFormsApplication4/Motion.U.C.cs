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
    public partial class Form7 : Form
    {
        public static Form7 Instance;
        public static Form7 get_instance()
        {
            if (Instance == null)
            {
                Instance = new Form7();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void Form7_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public Form7()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double w, f, t;
            if (textBox3.Text != String.Empty)
            {
                if (textBox2.Text != String.Empty)
                {
                    t = double.Parse(textBox2.Text);
                    f = double.Parse(textBox3.Text);
                    w = f / t;
                    textBox1.Text = Convert.ToString(w);
                }
                else if (textBox1.Text != String.Empty)
                {
                    f = double.Parse(textBox3.Text);
                    w = double.Parse(textBox1.Text);
                    t = f / w;
                    textBox2.Text = Convert.ToString(t);
                }
            }
            else if (textBox1.Text != String.Empty)
            {
                if (textBox2.Text != String.Empty)
                {
                    t = double.Parse(textBox2.Text);
                    w = double.Parse(textBox1.Text);
                    f = w * t;
                    textBox3.Text = Convert.ToString(f);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Motion f = Motion.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
