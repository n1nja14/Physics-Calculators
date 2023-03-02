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
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        public PowerTrenia()
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
                        MessageBoxDefaultButton.Button1
                        );
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
                        MessageBoxDefaultButton.Button1
                        );
                    }
                    else
                    {
                        u = f / n;
                        textBox2.Text = Convert.ToString(u);
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
            else if (textBox3.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    u = double.Parse(textBox3.Text);
                    n = double.Parse(textBox2.Text);
                    f = n * u;
                    textBox1.Text = Convert.ToString(f);
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
            PowerTreniaTheory.get_instance().Hide();
            Power f = Power.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PowerTreniaTheory f = PowerTreniaTheory.get_instance();
            f.Show();
        }
    }
}
