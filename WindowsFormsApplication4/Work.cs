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
    public partial class Work : Form
    {
        public static Work Instance;
        public static Work get_instance()
        {
            if (Instance == null)
            {
                Instance = new Work();
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
        public Work()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f = Form8.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mechanics f = Mechanics.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f = Form9.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = Form2.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WorkEnergy f = WorkEnergy.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
