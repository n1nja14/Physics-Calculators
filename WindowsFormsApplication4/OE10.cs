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
    public partial class OE10 : Form
    {
        public OE10()
        {
            InitializeComponent();
        }
        public static OE10 Instance;
        public static OE10 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE10();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dr = MessageBox.Show("Хотите закончить тест не пройдя его полностью ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == dr)
            {
                e.Cancel = true;
                Hide();
            }
            else
            {
                e.Cancel = dr == DialogResult.No;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OE9 f = OE9.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == false) && (radioButton2.Checked == false) && (radioButton3.Checked == false) && (radioButton4.Checked == false))
            {
                MessageBox.Show(
                "Остались пустые поля!",
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
                );
            }
            else
            {
                if (radioButton3.Checked)
                {
                    OE1.Data.p += 1;
                }
                MessageBox.Show(
                "Кол-ов баллов: " + OE1.Data.p,
                "Конец",
                MessageBoxButtons.OK);
                Hide();
                OE1.Data.p = 0;
            }
        }
    }
}
