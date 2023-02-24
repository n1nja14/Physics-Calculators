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
    public partial class PowerNewton : Form
    {
        public PowerNewton()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                if (textBox2.Text != String.Empty)
                {
                    double m, a, f;
                    a = double.Parse(textBox1.Text);
                    m = double.Parse(textBox2.Text);
                    f = a * m;
                    textBox3.Text = Convert.ToString(f);
                }
                else if (textBox3.Text != String.Empty)
                {
                    double m, a, f;
                    f = double.Parse(textBox3.Text);
                    a = double.Parse(textBox1.Text);
                    if (a == 0)
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
                        m = f / a;
                        textBox2.Text = Convert.ToString(m);
                    }
                }
            }
            else if (textBox2.Text != string.Empty)
            {
                if (textBox3.Text != String.Empty)
                {
                    double m, a, f;
                    f = double.Parse(textBox3.Text);
                    m = double.Parse(textBox2.Text);
                    if (m == 0)
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
                        a = f / m;
                        textBox1.Text = Convert.ToString(a);
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Power p = new Power();
            p.StartPosition = FormStartPosition.Manual;
            p.Location = Location;
            p.Show();
            Close();
        }

        private void Newton_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PowerNewtonTheory f = new PowerNewtonTheory();
            f.Show();
        }
    }
}

