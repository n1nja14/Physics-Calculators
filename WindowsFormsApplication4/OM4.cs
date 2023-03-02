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
    public partial class OM4 : Form
    {
        public OM4()
        {
            InitializeComponent();
        }
        public static OM4 Instance;
        public static OM4 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OM4();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OM3 f = OM3.get_instance();
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
                if (radioButton3.Checked)
                {
                    OM1.lData.r += 1;
                }
                OM5 f = OM5.get_instance();
                f.StartPosition = FormStartPosition.Manual;
                f.Location = Location;
                f.Show();
                Hide();
            }
        }

        private void OM4_Load(object sender, EventArgs e)
        {

        }
    }
}
