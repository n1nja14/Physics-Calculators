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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Power f = new Power();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PowerGukTheory f = new PowerGukTheory();
            f.Show();
        }
    }
}
