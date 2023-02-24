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
    public partial class Motion : Form
    {
        public static Motion Instance;
        public static Motion get_instance()
        {
            if (Instance == null)
            {
                Instance = new Motion();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void Motion_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        public Motion()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = Form5.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mechanics f = Mechanics.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f = Form6.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void Motion_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MotionFreeFall f = MotionFreeFall.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f = Form7.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
