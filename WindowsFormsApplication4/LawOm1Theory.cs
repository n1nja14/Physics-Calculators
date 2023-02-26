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
    public partial class LawOm1Theory : Form
    {
        public static LawOm1Theory Instance;
        public static LawOm1Theory get_instance()
        {
            if (Instance == null)
            {
                Instance = new LawOm1Theory();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        public LawOm1Theory()
        {
            InitializeComponent();
        }
    }
}
