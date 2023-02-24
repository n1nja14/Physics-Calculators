﻿using System;
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
            else { return Instance; }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator fr2 = new Calculator();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mechanics r = Mechanics.get_instance();
            r.StartPosition = FormStartPosition.Manual;
            r.Location = Location;
            r.Show();
            Hide();
            /*Mechanics fr3 = new Mechanics();
                        fr3.StartPosition = FormStartPosition.Manual;
                        fr3.Location = Location;
                        fr3.Show();
                        Hide();*/
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
            AaTest f = new AaTest();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LawElecricity f = new LawElecricity();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Main_Closing(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            
        }
    }
}