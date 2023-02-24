using System;
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
    public partial class Amper : Form
    {
        public Amper()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f, b, i, l, a;
            if (textBox2.Text != String.Empty)
            {
                if (textBox3.Text != String.Empty)
                {
                    if (textBox4.Text != String.Empty)
                    {
                        if (textBox5.Text != String.Empty)
                        {
                            b = double.Parse(textBox2.Text);
                            i = double.Parse(textBox3.Text);
                            l = double.Parse(textBox4.Text);
                            a = double.Parse(textBox5.Text);
                            f = b * Math.Abs(i) * l * (Math.Sin(a));
                            textBox1.Text = Convert.ToString(f);
                        }
                    }
                    else if (textBox1.Text != String.Empty)
                    {
                        if (textBox5.Text != String.Empty)
                        {
                            b = double.Parse(textBox2.Text);
                            i = double.Parse(textBox3.Text);
                            a = double.Parse(textBox5.Text);
                            f = double.Parse(textBox1.Text);
                            if ((b * Math.Abs(i) * (Math.Sin(a))) == 0)
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
                                l = f / (b * Math.Abs(i) * (Math.Sin(a)));
                                textBox4.Text = Convert.ToString(l);
                            }
                        }
                    }
                }
                else if (textBox1.Text != String.Empty)
                {
                    if (textBox5.Text != String.Empty)
                    {
                        if (textBox4.Text != String.Empty)
                        {
                            b = double.Parse(textBox2.Text);
                            l = double.Parse(textBox4.Text);
                            a = double.Parse(textBox5.Text);
                            f = double.Parse(textBox1.Text);
                            if (f / (b * l * (Math.Sin(a))) < 0)
                            {
                                MessageBox.Show(
                                "Модуль не может равняться отрицательному значению!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            else if ((b * l * (Math.Sin(a))) == 0)
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
                                i = f / (b * l * (Math.Sin(a)));
                                textBox3.Text = Convert.ToString(i);
                            }
                        }
                    }
                }
            }
            else if (textBox1.Text != String.Empty)
            {
                if (textBox5.Text != String.Empty)
                {
                    if (textBox4.Text != String.Empty)
                    {
                        if (textBox3.Text != String.Empty)
                        {
                            l = double.Parse(textBox4.Text);
                            i = double.Parse(textBox3.Text);
                            a = double.Parse(textBox5.Text);
                            f = double.Parse(textBox1.Text);
                            if ((Math.Abs(i) * l * (Math.Sin(a))) == 0)
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
                                b = f / (Math.Abs(i) * l * (Math.Sin(a)));
                                textBox2.Text = Convert.ToString(b);
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LawElecricity f = new LawElecricity();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }
    }
}

