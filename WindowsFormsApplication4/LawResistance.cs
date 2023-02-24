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
    public partial class LawResistance : Form
    {
        public LawResistance()
        {
            InitializeComponent();
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            LawElecricity f = new LawElecricity();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p, l, s, r;
            if (textBox2.Text != String.Empty)
            {
                if (textBox3.Text != String.Empty)
                {
                    if (textBox4.Text != String.Empty)
                    {
                        p = double.Parse(textBox2.Text);
                        l = double.Parse(textBox3.Text);
                        s = double.Parse(textBox4.Text);
                        if (s == 0)
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
                            r = p * l / s;
                            textBox1.Text = Convert.ToString(r);
                        }
                    }
                    else if (textBox1.Text != String.Empty)
                    {
                        p = double.Parse(textBox2.Text);
                        l = double.Parse(textBox3.Text);
                        r = double.Parse(textBox1.Text);
                        if (r == 0)
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
                            s = p * l / r;
                            textBox4.Text = Convert.ToString(s);
                        }
                    }
                }
                else if (textBox1.Text != String.Empty)
                {
                    if (textBox4.Text != String.Empty)
                    {
                        p = double.Parse(textBox2.Text);
                        s = double.Parse(textBox4.Text);
                        r = double.Parse(textBox1.Text);
                        if (p == 0)
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
                            l = r * s / p;
                            textBox3.Text = Convert.ToString(l);
                        }
                    }
                }
            }
            else if (textBox3.Text != String.Empty)
            {
                if (textBox4.Text != String.Empty)
                {
                    if (textBox1.Text != String.Empty)
                    {

                        l = double.Parse(textBox3.Text);
                        s = double.Parse(textBox4.Text);
                        r = double.Parse(textBox1.Text);
                        if (l == 0)
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
                            p = r * s / l;
                            textBox2.Text = Convert.ToString(p);
                        }
                    
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LawResistanceTheory f = new LawResistanceTheory();
            f.Show();
        }
    }
}