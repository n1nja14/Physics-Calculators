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
    public partial class Main : Form
    {
        public static Main Instance;
        public static Main get_instance()
        {
            if (Instance == null)
            {
                Instance = new Main();
                return Instance;
            }
            else 
            { 
                return Instance; 
            }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator r = Calculator.get_instance();
            r.StartPosition = FormStartPosition.Manual;
            r.Location = Location;
            r.Show();
            Hide();
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Mechanics r = Mechanics.get_instance();
            r.StartPosition = FormStartPosition.Manual;
            r.Location = Location;
            r.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Info f = new Info();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            C f = new C();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LawElecricity f = LawElecricity.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void Main_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
