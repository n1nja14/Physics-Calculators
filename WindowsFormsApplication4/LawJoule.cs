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
    public partial class LawJoule : Form
    {
        public static LawJoule Instance;
        public static LawJoule get_instance()
        {
            if (Instance == null)
            {
                Instance = new LawJoule();
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
        public LawJoule()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double q, i, t, r;
            if (textBox2.Text != String.Empty)
            {
                if (textBox3.Text != String.Empty)
                {
                    if (textBox4.Text != String.Empty)
                    {
                        
                        i = double.Parse(textBox2.Text);
                        t = double.Parse(textBox3.Text);
                        r = double.Parse(textBox4.Text);
                        q=i*i*r*t;
                        textBox1.Text = Convert.ToString(q);
                    }
                    else if (textBox1.Text != String.Empty)
                    {
                        i = double.Parse(textBox2.Text);
                        t = double.Parse(textBox3.Text);
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
                        else if (t == 0)
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
                            q = double.Parse(textBox1.Text);
                            r = q / (i * i * t);
                            textBox4.Text = Convert.ToString(r);
                        }
                    }
                }
                else if (textBox4.Text != String.Empty)
                {
                    if (textBox1.Text != String.Empty)
                    {
                        r = double.Parse(textBox4.Text);
                        i = double.Parse(textBox2.Text);
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
                        else if (r == 0)
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
                            q = double.Parse(textBox1.Text);
                            t = q / (i * i * r);
                            textBox3.Text = Convert.ToString(t);
                        }
                    }
                }
            }
            else if (textBox4.Text != String.Empty)
            {
                if (textBox1.Text != String.Empty)
                {
                    if (textBox3.Text != String.Empty)
                    {
                        r = double.Parse(textBox4.Text);
                        t = double.Parse(textBox3.Text);
                        q = double.Parse(textBox1.Text);
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
                        else if (t == 0)
                        {
                            MessageBox.Show(
                            "Деление на ноль невозможно!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else if ((q / (r * t)) < 0 )
                        {
                            MessageBox.Show(
                            "Подкоренное выражение больше, либо равно 0!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            i = Math.Sqrt(q / (r * t));
                            textBox2.Text = Convert.ToString(i);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LawElecricity f = LawElecricity.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LawJouleTheory f = new LawJouleTheory();
            f.Show();
        }
    }
}
