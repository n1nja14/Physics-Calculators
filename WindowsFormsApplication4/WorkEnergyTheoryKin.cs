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
    public partial class WorkEnergyTheoryKin : Form
    {
        public static WorkEnergyTheoryKin Instance;
        public static WorkEnergyTheoryKin get_instance()
        {
            if (Instance == null)
            {
                Instance = new WorkEnergyTheoryKin();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        public WorkEnergyTheoryKin()
        {
            InitializeComponent();
        }
    }
}
