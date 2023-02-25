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
    public partial class Calculator : Form
    {
        public static Calculator Instance;
        public static Calculator get_instance()
        {
            if (Instance == null)
            {
                Instance = new Calculator();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Main f = Main.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
/*        private void Calculator_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }*/
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double  first, second, result;
            if (radioButton1.Checked)
            {
                first = Double.Parse(textBox1.Text);
                second = Double.Parse(textBox2.Text);
                result = first + second;
                textBox3.Text = Convert.ToString(result);
            }
            else if (radioButton2.Checked)
            {
                first = Double.Parse(textBox1.Text);
                second = Double.Parse(textBox2.Text);
                result = first - second;
                textBox3.Text = Convert.ToString(result);
            }
            else if (radioButton3.Checked)
            {
                first = Double.Parse(textBox1.Text);
                second = Double.Parse(textBox2.Text);
                result = first * second;
                textBox3.Text = Convert.ToString(result);
            }
            else if (radioButton4.Checked)
            {
                second = Double.Parse(textBox2.Text);
                if (second == 0)
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
                    first = Double.Parse(textBox1.Text);
                    second = Double.Parse(textBox2.Text);
                    result = first / second;
                    textBox3.Text = Convert.ToString(result);
                }
            }
            else if (radioButton5.Checked)
            {
                first = Double.Parse(textBox1.Text);
                if (first < 0)
                {
                    MessageBox.Show(
                    "Подкоренное выражение должно быть больше, либо равно 0!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    result = Math.Sqrt(first);
                    textBox3.Text = Convert.ToString(result);
                }
            }
            else if (radioButton6.Checked)
            {
                first = Double.Parse(textBox1.Text);
                second = Double.Parse(textBox2.Text);
                result = Math.Pow(first, second);
                textBox3.Text = Convert.ToString(result);
            }
            else
            {
                
            }
        }

        

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
