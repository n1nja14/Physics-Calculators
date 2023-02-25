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
    public partial class MotionFreeFall : Form
    {
        public static MotionFreeFall Instance;
        public static MotionFreeFall get_instance()
        {
            if (Instance == null)
            {
                Instance = new MotionFreeFall();
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
                Application.Exit();
            }
        }
        public MotionFreeFall()
        {
            InitializeComponent();
        }
        
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s, v0, t;
            if (textBox3.Text != String.Empty)
            {
                if (textBox2.Text != String.Empty)
                {
                    t = double.Parse(textBox2.Text);
                    v0 = double.Parse(textBox3.Text);
                    s = v0 * t + 9.8 * t * t / 2;
                    textBox1.Text = Convert.ToString(s);
                }
                else if (textBox1.Text != String.Empty)
                {
                    double x, t1, t2;
                    s = double.Parse(textBox1.Text);
                    v0 = double.Parse(textBox3.Text);
                    x = Math.Sqrt((2 * v0 * 2 * v0) - (4 * (-2) * s * 9.8));
                    t1 = (-2 * v0 - x) / (2 * 9.8);
                    t2 = (-2 * v0 + x) / (2 * 9.8);
                    if (t1 < 0)
                    {
                        if (t2 < 0)
                        {
                            textBox2.Text = Convert.ToString("Нет ответа.");
                        }
                        else if (t2 >= 0)
                        {
                            textBox2.Text = Convert.ToString(t2);
                        }
                    }
                    else if (t1 >= 0)
                    {
                        if (t2 < 0)
                        {
                            textBox2.Text = Convert.ToString(t1);
                        }
                        else if (t2 >= 0)
                        {
                            if (t2 > t1)
                            {
                                textBox2.Text = Convert.ToString(t1);
                            }
                            else
                            {
                                textBox2.Text = Convert.ToString(t2);
                            }
                        }
                    }
                }
            }
            else if (textBox1.Text != String.Empty)
            {
                if (textBox2.Text != String.Empty)
                {
                    t = double.Parse(textBox2.Text);
                    s = double.Parse(textBox1.Text);
                    v0 = (s - ((9.8*t *t )/ 2)) / t;
                    textBox3.Text = Convert.ToString(v0);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Motion f = Motion.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }
    }
}
