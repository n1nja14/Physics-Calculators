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
    public partial class OE8 : Form
    {
        public OE8()
        {
            InitializeComponent();
        }
        public static OE8 Instance;
        public static OE8 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE8();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OE7 f = OE7.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                OE1.Data.p += 1;
            }
            OE9 f = OE9.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
