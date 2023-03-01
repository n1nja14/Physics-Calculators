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
    public partial class OE10 : Form
    {
        public OE10()
        {
            InitializeComponent();
        }
        public static OE10 Instance;
        public static OE10 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE10();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OE9 f = OE9.get_instance();
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
            MessageBox.Show(
                "Кол-ов баллов: " + OE1.Data.p,
                "Конец",
                MessageBoxButtons.OK);
            Main f = Main.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
