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
    public partial class Info : Form
    {
        public static Info Instance;
        public static Info get_instance()
        {
            if (Instance == null)
            {
                Instance = new Info();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        public Info()
        {
            InitializeComponent();
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
            Main r = Main.get_instance();
            r.StartPosition = FormStartPosition.Manual;
            r.Location = Location;
            r.Show();
            Hide();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LawJoule f = LawJoule.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LawOm1 f = LawOm1.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LawPowerElectricity f = LawPowerElectricity.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LawResistance f = LawResistance.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            LawOmFull f = LawOmFull.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Form5 f = Form5.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            MotionFreeFall f = MotionFreeFall.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Form6 f = Form6.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Form7 f = Form7.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            Form1 f = Form1.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            PowerGuk f = PowerGuk.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            PowerTrenia f = PowerTrenia.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            PowerNewton f = PowerNewton.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            Form8 f = Form8.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            Form9 f = Form9.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Form2 f = Form2.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            WorkEnergy f = WorkEnergy.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
