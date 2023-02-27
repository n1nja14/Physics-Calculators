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
    public partial class PowerNewtonTheory : Form
    {
        public static PowerNewtonTheory Instance;
        public static PowerNewtonTheory get_instance()
        {
            if (Instance == null)
            {
                Instance = new PowerNewtonTheory();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        public PowerNewtonTheory()
        {
            InitializeComponent();
        }
    }
}
