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
    public partial class OE9 : Form
    {
        public OE9()
        {
            InitializeComponent();
        }
        public static OE9 Instance;
        public static OE9 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE9();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OE8 f = OE8.get_instance();
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
            OE10 f = OE10.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
