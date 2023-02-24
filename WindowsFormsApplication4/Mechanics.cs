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

    

    public partial class Mechanics : Form
    {
        public static Mechanics r;
        public static Mechanics get_instance()
        {

            if (r == null)
            {
                r = new Mechanics();
                return r;
            }
            else
            {
                return r;
            }
        }

        public Mechanics()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Motion fr4 = new Motion();
            fr4.StartPosition = FormStartPosition.Manual;
            fr4.Location = Location;
            fr4.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main r = Main.get_instance();
            r.StartPosition = FormStartPosition.Manual;
            r.Location = Location;
            r.Show();
            Hide();
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Power l = new Power();
            l.StartPosition = FormStartPosition.Manual;
            l.Location = Location;
            l.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work fr7 = new Work();
            fr7.StartPosition = FormStartPosition.Manual;
            fr7.Location = Location;
            fr7.Show();
            Hide();
        }
    }
}
