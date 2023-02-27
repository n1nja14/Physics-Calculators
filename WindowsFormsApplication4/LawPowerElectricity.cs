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
    public partial class LawPowerElectricity : Form
    {
        public static LawPowerElectricity Instance;
        public static LawPowerElectricity get_instance()
        {
            if (Instance == null)
            {
                Instance = new LawPowerElectricity();
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
        private void button1_Click(object sender, EventArgs e)
        {
            LawPowerElectricityTheory.get_instance().Hide();
            LawElecricity f = LawElecricity.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        public LawPowerElectricity()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {

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
            double i, q, t;
            if (textBox2.Text != String.Empty)
            {
                if (textBox3.Text != String.Empty)
                {
                    t = double.Parse(textBox2.Text);
                    q = double.Parse(textBox3.Text);
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
                        i = q / t;
                        textBox1.Text = Convert.ToString(i);
                    }
                }
                else if (textBox1.Text != String.Empty)
                {
                    t = double.Parse(textBox2.Text);
                    i = double.Parse(textBox1.Text);
                    q = i * t;
                    textBox3.Text = Convert.ToString(q);
                }
            }
            else if (textBox1.Text != String.Empty)
            {
                if (textBox3.Text != String.Empty)
                {
                    q = double.Parse(textBox3.Text);
                    i = double.Parse(textBox1.Text);
                    if (i == 0)
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
                        t = q / i;
                        textBox2.Text = Convert.ToString(t);
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LawPowerElectricityTheory f = LawPowerElectricityTheory.get_instance();
            f.Show();
        }
    }
}