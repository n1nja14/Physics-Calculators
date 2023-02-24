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
    public partial class Power : Form
    {
        public static Power Instance;
        public static Power get_instance()
        {
            if (Instance == null)
            {
                Instance = new Power();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void Power_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public Power()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mechanics f = Mechanics.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = Form1.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PowerNewton f = PowerNewton.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Power_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PowerGuk f = PowerGuk.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PowerTrenia f = PowerTrenia.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
