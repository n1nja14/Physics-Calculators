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
    public partial class PowerArhimedTheory : Form
    {
        public static PowerArhimedTheory Instance;
        public static PowerArhimedTheory get_instance()
        {
            if (Instance == null)
            {
                Instance = new PowerArhimedTheory();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        public PowerArhimedTheory()
        {
            InitializeComponent();
        }
    }
}
