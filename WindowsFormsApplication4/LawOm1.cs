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
    public partial class LawOm1 : Form
    {
        public static LawOm1 Instance;
        public static LawOm1 get_instance()
        {
            if (Instance == null)
            {
                Instance = new LawOm1();
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
        public LawOm1()
        {
            InitializeComponent();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            double i, r, u;
            if (textBox2.Text != String.Empty)
               {
                if (textBox1.Text != String.Empty)
                {
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
                        u = double.Parse(textBox2.Text);
                        r = u / i;
                        textBox3.Text = Convert.ToString(r);
                    }
                }
                else if (textBox3.Text != String.Empty)
                {
                    r = double.Parse(textBox3.Text);
                    if (r == 0)
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
                        u = double.Parse(textBox2.Text);
                        i = u / r;
                        textBox1.Text = Convert.ToString(i);
                    }
                }
            }
            else if (textBox1.Text != String.Empty)
            {
                if (textBox3.Text != String.Empty)
                {
                    i = double.Parse(textBox1.Text);
                    r = double.Parse(textBox3.Text);
                    u = r * i;
                    textBox2.Text = Convert.ToString(u);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LawOm1Theory.get_instance().Hide();
            LawElecricity f = LawElecricity.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LawOm1Theory f = LawOm1Theory.get_instance();
            f.Show();
        }
    }
}

