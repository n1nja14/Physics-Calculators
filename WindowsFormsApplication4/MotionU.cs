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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double s, v, t;
            if (textBox3.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    t = double.Parse(textBox3.Text);
                    v = double.Parse(textBox2.Text);
                    s = v * t;
                    textBox1.Text = Convert.ToString(s);
                }

                else if (textBox1.Text != string.Empty)
                {

                    t = double.Parse(textBox3.Text);
                    s = double.Parse(textBox1.Text);
                    if (t == 0)
                    {
                        MessageBox.Show(
                        "Деление на ноль невозможно!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        v = s / t;
                        textBox2.Text = Convert.ToString(v);

                    }
                }
            }
            else if (textBox2.Text != string.Empty)
            {
                if (textBox1.Text != string.Empty)
                {
                    s = double.Parse(textBox1.Text);
                    v = double.Parse(textBox2.Text);
                    if (v == 0)
                    {
                        MessageBox.Show(
                        "Деление на ноль невозможно!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        t = s / v;
                        textBox3.Text = Convert.ToString(t);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Motion f = new Motion();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }
    }

}