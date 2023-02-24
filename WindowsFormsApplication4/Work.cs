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
        public Work()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.StartPosition = FormStartPosition.Manual;
            fr8.Location = Location;
            fr8.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mechanics fr3 = new Mechanics();
            fr3.StartPosition = FormStartPosition.Manual;
            fr3.Location = Location; 
            fr3.Show();
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.StartPosition = FormStartPosition.Manual;
            fr9.Location = Location;
            fr9.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 fr9 = new Form2();
            fr9.StartPosition = FormStartPosition.Manual;
            fr9.Location = Location;
            fr9.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WorkEnergy f = new WorkEnergy();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }
    }
}
