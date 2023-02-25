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
        public static LawElecricity Instance;
        public static LawElecricity get_instance()
        {
            if (Instance == null)
            {
                Instance = new LawElecricity();
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
        public LawElecricity()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            LawOm1 f = LawOm1.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LawJoule f = LawJoule.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main f = Main.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LawOmFull f = LawOmFull.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LawPowerElectricity f = LawPowerElectricity.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LawResistance f  = LawResistance.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
