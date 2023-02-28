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
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public static Form2 get_instance()
        {
            if (Instance == null)
            {
                Instance = new Form2();
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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, s, f;
            if (textBox1.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    f = double.Parse(textBox1.Text);
                    s = double.Parse(textBox2.Text);
                    a = f * s;
                    textBox3.Text = Convert.ToString(a);
                }
                else if (textBox3.Text != string.Empty)
                {
                    f = double.Parse(textBox1.Text);
                    a = double.Parse(textBox3.Text);
                    if (f == 0)
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
                        s = a / f;
                        textBox2.Text = Convert.ToString(s);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Остались пустые поля!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else if (textBox3.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    a = double.Parse(textBox3.Text);
                    s = double.Parse(textBox2.Text);
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
                        f = a / s;
                        textBox1.Text = Convert.ToString(f);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Остались пустые поля!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else
            {
                MessageBox.Show(
                "Остались пустые поля!",
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
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

        
    }
}
