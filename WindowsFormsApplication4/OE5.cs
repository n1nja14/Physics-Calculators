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
    public partial class OE5 : Form
    {
        public OE5()
        {
            InitializeComponent();
        }
        public static OE5 Instance;
        public static OE5 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE5();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            OE4 f = OE4.get_instance();
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
            OE6 f = OE6.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
