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
    public partial class OE1 : Form
    {
        public static class Data
        {
            public static int p;
        }
        public static OE1 Instance;
        public static OE1 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE1();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Data.p = 0;
            if (radioButton1.Checked)
            {
               Data.p += 1;
            }
            OE2 f = OE2.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        public OE1()
        {
            InitializeComponent();
        }
    }
}
