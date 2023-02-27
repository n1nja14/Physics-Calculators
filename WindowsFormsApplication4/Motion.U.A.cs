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
    public partial class Form5 : Form
    {
        public static Form5 Instance;
        public static Form5 get_instance()
        {
            if (Instance == null)
            {
                Instance = new Form5();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        public Form5()
        {
            InitializeComponent();
        }
        
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s, a, v, t, v0, x, t1, t2;
            if (radioButton1.Checked)
            {
                if (textBox3.Text != string.Empty)
                {
                    if (textBox4.Text != string.Empty)
                    {
                        if (textBox5.Text != string.Empty)
                        {
                            v = double.Parse(textBox4.Text);
                            t = double.Parse(textBox3.Text);
                            v0 = double.Parse(textBox5.Text);
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
                                a = (v - v0) / t;

                                textBox1.Text = Convert.ToString(a);
                            }
                        }
                        else if (textBox1.Text != string.Empty)
                        {
                            v = double.Parse(textBox4.Text);
                            t = double.Parse(textBox3.Text);
                            a = double.Parse(textBox1.Text);
                            v0 = v - a * t;
                            textBox5.Text = Convert.ToString(v0);
                        }
                    }
                    else if (textBox5.Text != string.Empty)
                    {
                        if (textBox1.Text != string.Empty)
                        {
                            v0 = double.Parse(textBox5.Text);
                            t = double.Parse(textBox3.Text);
                            a = double.Parse(textBox1.Text);
                            v = v0 + a * t;
                            textBox4.Text = Convert.ToString(v);
                        }
                    }

                }
                else if (textBox5.Text != string.Empty)
                {
                    if (textBox1.Text != string.Empty)
                    {
                        if (textBox4.Text != string.Empty)
                        {
                            v0 = double.Parse(textBox5.Text);
                            v = double.Parse(textBox4.Text);
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
                                t = (v - v0) / a;
                                textBox3.Text = Convert.ToString(t);
                            }
                        }
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                if (textBox5.Text != string.Empty)
                {
                    if (textBox1.Text != string.Empty)
                    {
                        if (textBox3.Text != string.Empty)
                        {
                            a = double.Parse(textBox1.Text);
                            t = double.Parse(textBox3.Text);
                            v0 = double.Parse(textBox5.Text);
                            v = v0 + a * t;
                            textBox4.Text = Convert.ToString(v);
                        }
                        else if (textBox4.Text != string.Empty)
                        {
                            a = double.Parse(textBox1.Text);
                            v = double.Parse(textBox4.Text);
                            v0 = double.Parse(textBox5.Text);
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
                                t = (v - v0) / a;
                                textBox3.Text = Convert.ToString(t);
                            }
                        }
                    }
                    else if (textBox3.Text != string.Empty)
                    {
                        if (textBox4.Text != string.Empty)
                        {
                            t = double.Parse(textBox3.Text);
                            v = double.Parse(textBox4.Text);
                            v0 = double.Parse(textBox5.Text);
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
                                a = (v - v0) / t;
                                textBox1.Text = Convert.ToString(a);
                            }
                        }
                    }
                }
                else if (textBox3.Text != string.Empty)
                {
                    if (textBox4.Text != string.Empty)
                    {
                        if (textBox1.Text != string.Empty)
                        {
                            t = double.Parse(textBox3.Text);
                            v = double.Parse(textBox4.Text);
                            a = double.Parse(textBox1.Text);
                            v0 = v - a * t;
                            textBox5.Text = Convert.ToString(v0);
                        }
                    }
                }
            }
            else if (radioButton3.Checked)
            {
                if (textBox3.Text != string.Empty)
                {
                    if (textBox5.Text != string.Empty)
                    {
                        if (textBox1.Text != string.Empty)
                        {
                            a = double.Parse(textBox1.Text);
                            t = double.Parse(textBox3.Text);
                            v0 = double.Parse(textBox5.Text);
                            s = v0 * t + a * t * t / 2;
                            textBox2.Text = Convert.ToString(s);
                        }
                        else if (textBox2.Text != string.Empty)
                        {
                            s = double.Parse(textBox2.Text);
                            t = double.Parse(textBox3.Text);
                            v0 = double.Parse(textBox5.Text);
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
                                a = (2 * s - 2 * v0 * t) / t * t;
                                textBox1.Text = Convert.ToString(a);
                            }
                        }
                    }
                    else if (textBox1.Text != string.Empty)
                    {
                        if (textBox2.Text != string.Empty)
                        {
                            s = double.Parse(textBox2.Text);
                            t = double.Parse(textBox3.Text);
                            a = double.Parse(textBox1.Text);
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
                                v0 = (s - a * t * t / 2) / t;
                                textBox5.Text = Convert.ToString(v0);
                            }
                        }
                    }
                }
                else if (textBox1.Text != string.Empty)
                {
                    if (textBox2.Text != string.Empty)
                    {
                        if (textBox5.Text != string.Empty)
                        {
                            s = double.Parse(textBox2.Text);
                            v0 = double.Parse(textBox5.Text);
                            a = double.Parse(textBox1.Text);
                            if ((2 * v0 * 2 * v0) - (4 * (-2) * s * a) < 0)
                            {
                                MessageBox.Show(
                                "Нет решений!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            else if (a == 0)
                            {
                                MessageBox.Show(
                                "Нет решений!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            else
                            {
                                x = Math.Sqrt((2 * v0 * 2 * v0) - (4 * (-2) * s * a));
                                t1 = (-2 * v0 - x) / (2 * a);
                                t2 = (-2 * v0 + x) / (2 * a);
                                if (t1 == t2)
                                {
                                    textBox3.Text = "t=" + string.Format("{0:f2}", t1);
                                }
                                else if (t1 > 0 && t2 < 0)
                                {
                                    textBox3.Text = "t=" + string.Format("{0:f2}", t1);
                                }
                                else if (t1 < 0 && t2 > 0)
                                {
                                    textBox3.Text = "t=" + string.Format("{0:f2}", t2);
                                }
                                else if (t1 > 0 && t2 > 0)
                                {
                                    textBox3.Text = "t=" + string.Format("{0:f2}", t1) + " ||t=" + string.Format("{0:f2}", t2);
                                }
                                else
                                {
                                    textBox3.Text = "Корней нет";
                                }
                            }
                        }
                    }
                }
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Motion f = Motion.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

