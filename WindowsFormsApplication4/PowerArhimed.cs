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
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public static Form1 get_instance()
        {
            if (Instance == null)
            {
                Instance = new Form1();
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
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double f, v, p;
            if (textBox2.Text != string.Empty)
            {
                if (textBox1.Text != string.Empty)
                {

                    v = Double.Parse(textBox2.Text);
                    p = Double.Parse(textBox1.Text);
                    f = v * p * 9.8;
                    textBox3.Text = Convert.ToString(f);
                }
                else if (textBox3.Text != string.Empty)
                {

                    v = Double.Parse(textBox2.Text);
                    f = Double.Parse(textBox3.Text);
                    if (v == 0)
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
                        p = f / v * 9.8;
                        textBox1.Text = Convert.ToString(p);
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
            if (textBox1.Text != string.Empty)
            {
                if (textBox3.Text != string.Empty)
                {
                    f = Double.Parse(textBox3.Text);
                    p = Double.Parse(textBox1.Text);
                    if (p == 0)
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
                        v = f / p * 9.8;
                        textBox2.Text = Convert.ToString(v);
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

        private void button2_Click(object sender, EventArgs e)
        {
            PowerArhimedTheory.get_instance().Hide();
            Power f = Power.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PowerArhimedTheory f = PowerArhimedTheory.get_instance();
            f.Show();
        }
    }
}
