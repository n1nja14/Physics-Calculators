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
    public partial class WorkEnergyTheoryPot : Form
    {
        public static WorkEnergyTheoryPot Instance;
        public static WorkEnergyTheoryPot get_instance()
        {
            if (Instance == null)
            {
                Instance = new WorkEnergyTheoryPot();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        public WorkEnergyTheoryPot()
        {
            InitializeComponent();
        }
    }
}
