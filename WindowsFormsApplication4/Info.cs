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
    public partial class Info : Form
    {
        public static Info Instance;
        public static Info get_instance()
        {
            if (Instance == null)
            {
                Instance = new Info();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        public Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main r = Main.get_instance();
            r.StartPosition = FormStartPosition.Manual;
            r.Location = Location;
            r.Show();
            Hide();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
