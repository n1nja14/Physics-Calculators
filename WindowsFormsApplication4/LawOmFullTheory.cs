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
    public partial class LawOmFullTheory : Form
    {
        public static LawOmFullTheory Instance;
        public static LawOmFullTheory get_instance()
        {
            if (Instance == null)
            {
                Instance = new LawOmFullTheory();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        public LawOmFullTheory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
