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
    public partial class PowerGuk : Form
    {
        public static PowerGuk Instance;
        public static PowerGuk get_instance()
        {
            if (Instance == null)
            {
                Instance = new PowerGuk();
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
        public PowerGuk()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            double f, k, x;
            if (textBox1.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    f = double.Parse(textBox1.Text);
                    k = double.Parse(textBox2.Text);
                    if (k == 0)
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
                        x = -1 * f / k;
                        textBox3.Text = Convert.ToString(x);
                    }
                }
                else if (textBox3.Text != string.Empty)
                {
                    
                    f = double.Parse(textBox1.Text);
                    x = double.Parse(textBox3.Text);
                    if (x == 0)
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
                        k = -1 * f / x;
                        textBox2.Text = Convert.ToString(k);
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
                    x = double.Parse(textBox3.Text);
                    k = double.Parse(textBox2.Text);
                    f = -1 * x * k ;
                    textBox1.Text = Convert.ToString(f);
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
            PowerGukTheory.get_instance().Hide();
            Power f = Power.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PowerGukTheory f = PowerGukTheory.get_instance();
            f.Show();
        }
    }
}
