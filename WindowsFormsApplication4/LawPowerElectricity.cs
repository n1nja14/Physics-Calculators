﻿using System;
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
        private void LawPowerElectricity_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            LawPowerElectricityTheory f = new LawPowerElectricityTheory();
            f.Show();
        }
    }
}
