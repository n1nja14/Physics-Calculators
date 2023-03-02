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
    public partial class OM10 : Form
    {
        public OM10()
        {
            InitializeComponent();
        }
        public static OM10 Instance;
        public static OM10 get_instance()
        {
            if (Instance == null)
            {
                Instance = new OM10();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OM9 f = OM9.get_instance();
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
                MessageBox.Show(
                "Кол-ов баллов: " + OM1.lData.r,
                "Конец",
                MessageBoxButtons.OK);
                OM1.lData.r = 0;
                Hide();
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
