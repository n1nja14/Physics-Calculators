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
    public partial class OE6 : Form
    {
        public OE6()
        {
            InitializeComponent();
        }
        public static OE6 Instance;
        public static OE6 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE6();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OE5 f = OE5.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                OE1.Data.p += 1;
            }
            OE7 f = OE7.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
