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
    public partial class OM5 : Form
    {
        public OM5()
        {
            InitializeComponent();
        }
        public static OM5 Instance;
        public static OM5 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OM5();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OM4 f = OM4.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                OM1.lData.r += 1;
            }
            OM6 f = OM6.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
