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
    public partial class Form9 : Form
    {
        public static Form9 Instance;
        public static Form9 get_instance()
        {
            if (Instance == null)
            {
                Instance = new Form9();
                return Instance;
            }
            else
            {
                return Instance;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        public Form9()
        {
            InitializeComponent();
        }
        

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  a, f, s, k, x2, x1;
            if (radioButton1.Checked) 
            {
                if (textBox1.Text != string.Empty)
                {
                    if (textBox2.Text != string.Empty)
                    {
                        f = double.Parse(textBox2.Text);
                        s = double.Parse(textBox1.Text);
                        a = f * s;
                        textBox6.Text = Convert.ToString(a);
                    }
                    else if (textBox6.Text != string.Empty)
                    {
                        a = double.Parse(textBox6.Text);
                        s = double.Parse(textBox1.Text);
                        if (s == 0)
                        {
                            MessageBox.Show(
                            "Деление на ноль невозможно!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            f = a / s;
                            textBox2.Text = Convert.ToString(f);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else if (textBox2.Text != string.Empty)
                {
                    if (textBox6.Text != string.Empty)
                    {
                        a = double.Parse(textBox6.Text);
                        f = double.Parse(textBox2.Text);
                        if (f == 0)
                        {
                            MessageBox.Show(
                            "Деление на ноль невозможно!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            s = a / f;
                            textBox1.Text = Convert.ToString(s);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Остались пустые поля!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else if (radioButton2.Checked)        
            {
                if (textBox4.Text != string.Empty)
                {
                    if (textBox5.Text != string.Empty)
                    {
                        if (textBox3.Text != string.Empty)
                        {
                            if (textBox1.Text != string.Empty)
                            {
                                k = double.Parse(textBox4.Text);
                                x1 = double.Parse(textBox5.Text);
                                x2 = double.Parse(textBox3.Text);
                                s = double.Parse(textBox1.Text);
                                if (s == 0)
                                {
                                    MessageBox.Show(
                                    "Деление на ноль невозможно!",
                                    "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                }
                                else
                                {
                                    a = k * (x1 + x2) / 2 * s;
                                    textBox6.Text = Convert.ToString(a);
                                } 
                            }
                            else if (textBox6.Text != string.Empty)
                            {
                                k = double.Parse(textBox4.Text);
                                x1 = double.Parse(textBox5.Text);
                                x2 = double.Parse(textBox3.Text);
                                a = double.Parse(textBox6.Text);
                                if (k == 0)
                                {
                                    MessageBox.Show(
                                    "Деление на ноль невозможно!",
                                    "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                }
                                else if ((x1+x2) == 0)
                                {
                                    MessageBox.Show(
                                    "Деление на ноль невозможно!",
                                    "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                }
                                else
                                {
                                    s = 2 * a / (k * (x1 + x2));
                                    textBox1.Text = Convert.ToString(s);
                                } 
                                
                            }
                            else
                            {
                                MessageBox.Show(
                                "Остались пустые поля!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                        }
                        else if (textBox1.Text != string.Empty)
                        {
                            if (textBox6.Text != string.Empty)
                            {
                                k = double.Parse(textBox4.Text);
                                x1 = double.Parse(textBox5.Text);
                                s = double.Parse(textBox1.Text);
                                a = double.Parse(textBox6.Text);
                                if (k == 0)
                                {
                                    MessageBox.Show(
                                    "Деление на ноль невозможно!",
                                    "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                }
                                else if (s == 0)
                                {
                                    MessageBox.Show(
                                    "Деление на ноль невозможно!",
                                    "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                }
                                else
                                {
                                    x2 = (2 * a - k * x1 * s) / k * s;
                                    textBox3.Text = Convert.ToString(x2);
                                } 
                            }
                            else
                            {
                                MessageBox.Show(
                                "Остались пустые поля!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Остались пустые поля!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else if (textBox3.Text != string.Empty)
                    {
                        if (textBox1.Text != string.Empty)
                        {
                            if (textBox6.Text != string.Empty)
                            {
                                k = double.Parse(textBox4.Text);
                                x2 = double.Parse(textBox3.Text);
                                s = double.Parse(textBox1.Text);
                                a = double.Parse(textBox6.Text);
                                if (k == 0)
                                {
                                    MessageBox.Show(
                                    "Деление на ноль невозможно!",
                                    "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                }
                                else if (s == 0)
                                {
                                    MessageBox.Show(
                                    "Деление на ноль невозможно!",
                                    "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                }
                                else
                                {
                                    x1 = (2 * a - k * x2 * s) / k * s;
                                    textBox5.Text = Convert.ToString(x1);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                "Остались пустые поля!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Остались пустые поля!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else if (textBox3.Text != string.Empty)
                {
                    if (textBox1.Text != string.Empty)
                    {
                        if (textBox6.Text != string.Empty)
                        {
                            if (textBox5.Text != string.Empty)
                            {
                                x1 = double.Parse(textBox5.Text);
                                x2 = double.Parse(textBox3.Text);
                                s = double.Parse(textBox1.Text);
                                a = double.Parse(textBox6.Text);
                                if (s == 0)
                                {
                                    MessageBox.Show(
                                    "Деление на ноль невозможно!",
                                    "Внимание!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                }
                                else
                                {
                                    k = a / ((x1 + x2) / 2) * s;
                                    textBox4.Text = Convert.ToString(k);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                "Остались пустые поля!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Остались пустые поля!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Остались пустые поля!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else if (radioButton3.Checked)    
            {
                if (textBox3.Text != string.Empty)
                {
                    if (textBox5.Text != string.Empty)
                    {
                        if (textBox2.Text != string.Empty)
                        {
                            f = double.Parse(textBox2.Text);
                            x1 = double.Parse(textBox5.Text);
                            x2 = double.Parse(textBox3.Text);
                            a = f * (x1 - x2);
                            textBox6.Text = Convert.ToString(a);
                        }
                        else if (textBox6.Text != string.Empty)
                        {
                            a = double.Parse(textBox6.Text);
                            x1 = double.Parse(textBox5.Text);
                            x2 = double.Parse(textBox3.Text);
                            if ((x1 - x2) == 0)
                            {
                                MessageBox.Show(
                                "Деление на ноль невозможно!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            else
                            {
                                f = a / (x1 - x2);
                                textBox2.Text = Convert.ToString(f);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Остались пустые поля!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else if (textBox2.Text != string.Empty)
                    {
                        if (textBox6.Text != string.Empty)
                        {
                            a = double.Parse(textBox6.Text);
                            f = double.Parse(textBox2.Text);
                            x2 = double.Parse(textBox3.Text);
                            if (f == 0)
                            {
                                MessageBox.Show(
                                "Деление на ноль невозможно!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            else
                            {
                                x1 = (a / f) + x2;
                                textBox5.Text = Convert.ToString(x1);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Остались пустые поля!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else if (textBox5.Text != string.Empty)
                {
                    if (textBox2.Text != string.Empty)
                    {
                        if (textBox6.Text != string.Empty)
                        {
                            a = double.Parse(textBox6.Text);
                            f = double.Parse(textBox2.Text);
                            x1 = double.Parse(textBox5.Text);
                            if (f == 0)
                            {
                                MessageBox.Show(
                                "Деление на ноль невозможно!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            else
                            {
                                x2 = x1 - (a / f);
                                textBox3.Text = Convert.ToString(x2);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Остались пустые поля!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Остались пустые поля!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else if (radioButton4.Checked) 
            {
                if (textBox4.Text != string.Empty)
                {
                    if (textBox5.Text != string.Empty)
                    {
                        if (textBox3.Text != string.Empty)
                        {
                            k = double.Parse(textBox4.Text);
                            x1 = double.Parse(textBox5.Text);
                            x2 = double.Parse(textBox3.Text);
                            if ((x1 - x2) == 0)
                            {
                                MessageBox.Show(
                                "Деление на ноль невозможно!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            else
                            {
                                a = k * (x1 + x2) / 2 * (x1 - x2);
                                textBox6.Text = Convert.ToString(a);
                            }
                        }
                        else if (textBox6.Text != string.Empty)
                        {
                            k = double.Parse(textBox4.Text);
                            x1 = double.Parse(textBox5.Text);
                            a = double.Parse(textBox6.Text);
                            double g;
                            g = Math.Pow(x1, 2);
                            if ((g - (2 * a / k)) < 0)
                            {
                                MessageBox.Show(
                                "Подкоренное выражение должно быть больше, либо равно 0!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            else if (k == 0)
                            {
                                MessageBox.Show(
                                "Деление на ноль невозможно!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly
                                );
                            }
                            else
                            {
                                x2 = Math.Sqrt(g - (2 * a / k));
                                textBox3.Text = Convert.ToString(x2);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Остались пустые поля!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else if (textBox3.Text != string.Empty)
                    {
                        if (textBox6.Text != string.Empty)
                        {
                            k = double.Parse(textBox4.Text);
                            a = double.Parse(textBox6.Text);
                            x2 = double.Parse(textBox3.Text);
                            double g;
                            g = Math.Pow(x2, 2);
                            if ((g + (2 * a / k)) < 0)
                            {
                                MessageBox.Show(
                                "Подкоренное выражение должно быть больше, либо равно 0!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            else if (k == 0)
                            {
                                MessageBox.Show(
                                "Деление на ноль невозможно!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly
                                );
                            }
                            else
                            {
                                x1 = Math.Sqrt(g + (2 * a / k));
                                textBox5.Text = Convert.ToString(x1);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Остались пустые поля!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else if (textBox3.Text != string.Empty)
                {
                    if (textBox6.Text != string.Empty)
                    {
                        if (textBox5.Text != string.Empty)
                        {
                            x1 = double.Parse(textBox5.Text);
                            a = double.Parse(textBox6.Text);
                            x2 = double.Parse(textBox3.Text);
                            double g, u;
                            g = Math.Pow(x2, 2);
                            u = Math.Pow(x1, 2);
                            if ((u-g) == 0)
                            {
                                MessageBox.Show(
                                "Деление на ноль невозможно!",
                                "Внимание!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            }
                            k = 2 * a / (u - g);
                            textBox4.Text = Convert.ToString(k);
                        }
                        else
                        {
                            MessageBox.Show(
                            "Остались пустые поля!",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Остались пустые поля!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Остались пустые поля!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else
            {
                MessageBox.Show(
                "Выберите формулу!",
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work f = Work.get_instance();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = Location;
            f.Show();
            Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
