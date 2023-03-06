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

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
                Hide();
            
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
            if ((radioButton1.Checked == false) && (radioButton2.Checked == false) && (radioButton3.Checked == false) && (radioButton4.Checked == false))
            {
                MessageBox.Show(
                "Остались пустые поля!",
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
                );
            }
            else
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
}
