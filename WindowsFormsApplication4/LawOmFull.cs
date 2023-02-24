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
        public LawOmFull()
        {
            InitializeComponent();
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            LawElecricity f = new LawElecricity();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
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
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
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
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            r = (a - (i * R)) / i;
                            textBox4.Text = Convert.ToString(r);
                        }
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
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            R = (a - (i * r)) / i;
                            textBox3.Text = Convert.ToString(R);
                        }
                    }
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
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LawOmFullTheory f = new LawOmFullTheory();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
        }
    }
}
