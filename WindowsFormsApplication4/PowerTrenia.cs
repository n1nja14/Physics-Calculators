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
    public partial class PowerTrenia : Form
    {
        public static PowerTrenia Instance;
        public static PowerTrenia get_instance()
        {
            if (Instance == null)
            {
                Instance = new PowerTrenia();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void PowerTrenia_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public PowerTrenia()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double f, n, u;
            if (textBox1.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    f = double.Parse(textBox1.Text);
                    u = double.Parse(textBox2.Text);
                    if (u == 0)
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
                        n = f / u;
                        textBox3.Text = Convert.ToString(n);
                    }
                }
                else if (textBox3.Text != string.Empty)
                {
                    f = double.Parse(textBox1.Text);
                    n = double.Parse(textBox3.Text);
                    if (n == 0)
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
                        u = f / n;
                        textBox2.Text = Convert.ToString(u);
                    }
                }
            }
            else if (textBox3.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    u = double.Parse(textBox3.Text);
                    n = double.Parse(textBox2.Text);
                    f = n * u;
                    textBox1.Text = Convert.ToString(f);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Power f = Power.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PowerTreniaTheory f = new PowerTreniaTheory();
            f.Show();
        }
    }
}
