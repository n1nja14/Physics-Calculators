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
    public partial class AaTest : Form
    {
        public AaTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
           // int y;
       //     int q = 0;
            int l = 0;
         //   int g = 0;
            s = textBox1.Text;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        l = int.Parse(s[i].ToString());
        //        g = g * 10 + l;
        //    }

            int d = 0;
            Stack<int> num = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    l = int.Parse(s[i].ToString());
                    d = d * 10 + l;
                }
                else
                {
                    num.Push(d);
                    d = 0;
                }
            }
            num.Push(d);
            
     /*       for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    l = int.Parse(s[i].ToString());
                    g = g * 10 + l;
                }
                else if (s[i] == Convert.ToChar("+"))
                {
                    q = 0;
                }
                else if (s[i] == Convert.ToChar("-"))
                {
                    q = 1;
                }
                else if (s[i] == Convert.ToChar("*"))
                {
                    q = 2;
                }
                else if (s[i] == Convert.ToChar("/"))
                {
                    q = 3;
                }
                if (q == 1) // проверка знака
                {
                    num.Push((-1) * g);
                }
                else if (q == 2)
                {
                    int j;
                    j = num.Pop();
                    y =  j * g;
                }
                else if (q == 3)
                {
            //        int j;
                    y = num.Pop() / g;
                }
                else if (g == 0)
                {
                    num.Push(g);
                }  

         }*/    
            int o = 0;

            while(num.Count!=0)
            {
                o = o + num.Pop();
            }
            textBox2.Text = o.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
