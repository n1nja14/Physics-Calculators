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
    public partial class OE4 : Form
    {
        public static OE4 Instance;
        public static OE4 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OE4();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        
        public OE4()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
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
                if (radioButton1.Checked)
                {
                    OE1.Data.p += 1;
                }
                OE5 f = OE5.get_instance();
                f.StartPosition = FormStartPosition.Manual;
                f.Location = Location;
                f.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            OE3 f = OE3.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();            
        }
    }
}
