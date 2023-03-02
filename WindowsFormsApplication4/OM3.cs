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
    public partial class OM3 : Form
    {
        public OM3()
        {
            InitializeComponent();
        }
        public static OM3 Instance;
        public static OM3 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OM3();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OM2 f = OM2.get_instance();
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
                if (radioButton4.Checked)
                {
                    OM1.lData.r += 1;
                }
                OM4 f = OM4.get_instance();
                f.StartPosition = FormStartPosition.Manual;
                f.Location = Location;
                f.Show();
                Hide();
            }
        }
    }
}
