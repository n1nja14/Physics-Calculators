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
        public Motion()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.StartPosition = FormStartPosition.Manual;
            fr5.Location = Location;
            fr5.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mechanics fr3 = new Mechanics();
            fr3.StartPosition = FormStartPosition.Manual;
            fr3.Location = Location;
            fr3.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.StartPosition = FormStartPosition.Manual;
            fr6.Location = Location;
            fr6.Show();
            Close();
        }

        private void Motion_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MotionFreeFall f = new MotionFreeFall();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }
    }
}
