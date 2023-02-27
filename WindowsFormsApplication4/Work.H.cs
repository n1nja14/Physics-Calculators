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
    public partial class Form8 : Form
    {
        public static Form8 Instance;
        public static Form8 get_instance()
        {
            if (Instance == null)
            {
                Instance = new Form8();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        public Form8()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double a, m, h1, h2, ep1, ep2;
            if (radioButton1.Checked)
            {
                if (textBox2.Text != string.Empty)
                {
                    if (textBox3.Text != string.Empty)
                    {
                        if (textBox4.Text != string.Empty)
                        {
                            m = double.Parse(textBox2.Text);
                            h1 = double.Parse(textBox3.Text);
                            h2 = double.Parse(textBox4.Text);
                            a = m * 9.8 * (h2 - h1);
                            textBox1.Text = Convert.ToString(a);
                        }
                        else if (textBox1.Text != string.Empty)
                        {
                            m = double.Parse(textBox2.Text);
                            h1 = double.Parse(textBox3.Text);
                            a = double.Parse(textBox1.Text);
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
                                h2 = h1 - (a / 9.8 * m);
                                textBox4.Text = Convert.ToString(h2);
                            }
                        }
                    }
                    else if (textBox4.Text != string.Empty)
                    {
                        if (textBox1.Text != string.Empty)
                        {
                            m = double.Parse(textBox2.Text);
                            h2 = double.Parse(textBox4.Text);
                            a = double.Parse(textBox1.Text);
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
                                h1 = h2 + (a / 9.8 * m);
                                textBox3.Text = Convert.ToString(h1);
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
                            h2 = double.Parse(textBox4.Text);
                            h1 = double.Parse(textBox3.Text);
                            a = double.Parse(textBox1.Text);
                            if ((h2 - h1) == 0)
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
                                m = a / 9.8 * (h2 - h1);
                                textBox2.Text = Convert.ToString(m);
                            }
                        }
                    }
                }

            }
            else if (radioButton2.Checked)
            {
                if (textBox5.Text != string.Empty)
                {
                    if (textBox6.Text != string.Empty)
                    {
                        ep1 = double.Parse(textBox5.Text);
                        ep2 = double.Parse(textBox6.Text);
                        a = -1 * (ep2 - ep1);
                        textBox1.Text = Convert.ToString(a);
                    }
                    else if (textBox1.Text != string.Empty)
                    {
                        ep1 = double.Parse(textBox5.Text);
                        a = double.Parse(textBox1.Text);
                        ep2 = ep1 - a;
                        textBox6.Text = Convert.ToString(ep2);
                    }

                }
                else if (textBox1.Text != string.Empty)
                {
                    if (textBox6.Text != string.Empty)
                    {
                        ep2 = double.Parse(textBox6.Text);
                        a = double.Parse(textBox1.Text);
                        ep1 = ep2 + a;
                        textBox5.Text = Convert.ToString(ep1);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work f = Work.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
