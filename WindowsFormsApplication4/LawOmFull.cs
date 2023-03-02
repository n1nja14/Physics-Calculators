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
    public partial class LawOmFull : Form
    {
        public static LawOmFull Instance;
        public static LawOmFull get_instance()
        {
            if (Instance == null)
            {
                Instance = new LawOmFull();
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
        public LawOmFull()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LawOmFullTheory.get_instance().Hide();
            LawElecricity f = LawElecricity.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i, a, R, r;
            if (textBox2.Text != String.Empty)
            {
                if (textBox3.Text != String.Empty)
                {
                    if (textBox4.Text != String.Empty)
                    {
                        a = double.Parse(textBox2.Text);
                        R = double.Parse(textBox3.Text);
                        r = double.Parse(textBox4.Text);
                        if ((R + r) == 0)
                        {
                            MessageBox.Show(
                            "Деление на ноль невозможно!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1
                            );
                        }
                        else
                        {
                            i = a / (R + r);
                            textBox1.Text = Convert.ToString(i);
                        }
                    }
                    else if (textBox1.Text != String.Empty)
                    {
                        a = double.Parse(textBox2.Text);
                        R = double.Parse(textBox3.Text);
                        i = double.Parse(textBox1.Text);
                        if (i == 0)
                        {
                            MessageBox.Show(
                            "Деление на ноль невозможно!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1
                            );
                        }
                        else
                        {
                            r = (a - (i * R)) / i;
                            textBox4.Text = Convert.ToString(r);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                        );
                    }
                }
                else if (textBox1.Text != String.Empty)
                {
                    if (textBox4.Text != String.Empty)
                    {

                        a = double.Parse(textBox2.Text);
                        i = double.Parse(textBox1.Text);
                        r = double.Parse(textBox4.Text);
                        if (i == 0)
                        {
                            MessageBox.Show(
                            "Деление на ноль невозможно!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1
                            );
                        }
                        else
                        {
                            R = (a - (i * r)) / i;
                            textBox3.Text = Convert.ToString(R);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Остались пустые поля!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                }
            }
            else if (textBox1.Text != String.Empty)
            {
                if (textBox4.Text != String.Empty)
                {
                    if (textBox3.Text != String.Empty)
                    {
                        R = double.Parse(textBox3.Text);
                        i = double.Parse(textBox1.Text);
                        r = double.Parse(textBox4.Text);
                        a = i * (R + r);
                        textBox2.Text = Convert.ToString(a);
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Остались пустые поля!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "Остались пустые поля!",
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
                );
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LawOmFullTheory f = LawOmFullTheory.get_instance();
            f.Show();
        }
    }
}
