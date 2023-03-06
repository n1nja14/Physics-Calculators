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
        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
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
                    OE1.Data.p += 1;
                }
                MessageBox.Show(
                "Кол-ов баллов: " + OE1.Data.p,
                "Конец",
                MessageBoxButtons.OK);
                OE1.Data.p = 0;
                Application.OpenForms["OE1"].Close();
                Application.OpenForms["OE2"].Close();
                Application.OpenForms["OE3"].Close();
                Application.OpenForms["OE4"].Close();
                Application.OpenForms["OE5"].Close();
                Application.OpenForms["OE6"].Close();
                Application.OpenForms["OE7"].Close();
                Application.OpenForms["OE8"].Close();
                Application.OpenForms["OE9"].Close();
                OE1.Instance = null;
                OE2.Instance = null;
                OE3.Instance = null;
                OE4.Instance = null;
                OE5.Instance = null;
                OE6.Instance = null;
                OE7.Instance = null;
                OE8.Instance = null;
                OE9.Instance = null;
                OE10.Instance = null;
                Close();
            }
        }
    }
}
