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
    public partial class LawElecricity : Form
    {
        public LawElecricity()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            LawOm1 f = new LawOm1();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LawJoule f = new LawJoule();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LawOmFull f = new LawOmFull();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LawPowerElectricity f = new LawPowerElectricity();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LawResistance f = new LawResistance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }
    }
}
