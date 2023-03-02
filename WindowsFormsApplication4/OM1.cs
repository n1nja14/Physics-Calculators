using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApplication4.OE1;

namespace WindowsFormsApplication4
{
    public partial class OM1 : Form
    {
        public static class lData
        {
            public static int r;
        }
        public OM1()
        {
            InitializeComponent();
        }
        public static OM1 Instance;
        public static OM1 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OM1();
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
            lData.r = 0;
            if (radioButton3.Checked)
            {
                lData.r += 1;
            }
            OM2 f = OM2.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
