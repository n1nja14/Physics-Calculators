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
    public partial class PowerTreniaTheory : Form
    {
        public static PowerTreniaTheory Instance;
        public static PowerTreniaTheory get_instance()
        {
            if (Instance == null)
            {
                Instance = new PowerTreniaTheory();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        public PowerTreniaTheory()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
