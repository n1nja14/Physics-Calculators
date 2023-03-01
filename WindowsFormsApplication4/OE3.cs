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
    public partial class OE3 : Form
    {
        public static OE3 Instance;
        public static OE3 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE3();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        public OE3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OE2 f = OE2.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                OE1.Data.p += 1;
            }
            OE4 f = OE4.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
