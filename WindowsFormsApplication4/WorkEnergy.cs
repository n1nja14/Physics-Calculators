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
    public partial class WorkEnergy : Form
    {
        public static WorkEnergy Instance;
        public static WorkEnergy get_instance()
        {
            if (Instance == null)
            {
                Instance = new WorkEnergy();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void WorkEnergy_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public WorkEnergy()
        {
            InitializeComponent();
        }
        

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double E, m;
            if (radioButton1.Checked)
            {
                double v;
                if (textBox2.Text != string.Empty)
                {
                    if (textBox3.Text != string.Empty)
                    {
                        m = double.Parse(textBox2.Text);
                        v = double.Parse(textBox3.Text);
                        E = (m * v * v) / 2;
                        textBox1.Text = Convert.ToString(E);
                    }
                    else if (textBox1.Text != string.Empty)
                    {
                        m = double.Parse(textBox2.Text);
                        E = double.Parse(textBox1.Text);
                        if (((2 * E) / m) < 0)
                        {
                            MessageBox.Show(
                            "Подкоренное выражение не может быть меньше, либо равно 0!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else if (m == 0)
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
                            {
                                v = Math.Sqrt((2 * E) / m);
                                textBox3.Text = Convert.ToString(v);
                            }
                        }
                    }
                    else
                    if (textBox1.Text != string.Empty)
                    {
                        if (textBox3.Text != string.Empty)
                        {
                            E = double.Parse(textBox1.Text);
                            v = double.Parse(textBox3.Text);
                            if (v == 0)
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
                                m = 2 * E / (v * v);
                                textBox2.Text = Convert.ToString(m);
                            }
                        }
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                double h;
                if (textBox4.Text != string.Empty)
                {
                    if (textBox5.Text != string.Empty)
                    {
                        m = double.Parse(textBox5.Text);
                        h = double.Parse(textBox4.Text);
                        E = m * 9.8 * h;
                        textBox6.Text = Convert.ToString(E);
                    }
                    else if (textBox6.Text != string.Empty)
                    {
                        E = double.Parse(textBox6.Text);
                        h = double.Parse(textBox4.Text);
                        if (h == 0)
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
                            m = E / (9.8 * h);
                            textBox5.Text = Convert.ToString(m);
                        }
                    }
                }
                else if (textBox5.Text != string.Empty)
                {
                    if (textBox6.Text != string.Empty)
                    {
                        E = double.Parse(textBox6.Text);
                        m = double.Parse(textBox5.Text);
                        if (m == 0)
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
                            h = E / (m * 9.8);
                            textBox4.Text = Convert.ToString(h);
                        }
                    }
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            WorkEnergyTheoryKin f = new WorkEnergyTheoryKin();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WorkEnergyTheoryPot f = new WorkEnergyTheoryPot();
            f.Show();
        }
    }
}
