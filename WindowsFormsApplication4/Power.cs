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
        public Power()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mechanics o = new Mechanics();
            o.StartPosition = FormStartPosition.Manual;
            o.Location = Location;
            o.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PowerNewton f = new PowerNewton();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Power_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PowerGuk f = new PowerGuk();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PowerTrenia f = new PowerTrenia();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Close();
        }
    }
}
