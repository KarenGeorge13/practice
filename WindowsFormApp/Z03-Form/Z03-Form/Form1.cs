using System;
using System.Drawing;
using System.Windows.Forms;

namespace Z03_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap("func.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, y1, y2, y3;
            bool point1 = double.TryParse(textBox1.Text, out x1) & double.TryParse(textBox2.Text, out y1);
            bool point2 = double.TryParse(textBox3.Text, out x2) & double.TryParse(textBox4.Text, out y2);
            bool point3 = double.TryParse(textBox5.Text, out x3) & double.TryParse(textBox6.Text, out y3);
            if (point1 && point2 && point3)
            {
                if (t(f(x1, y1, x2, y2), f(x1, y1, x3, y3), f(x2, y2, x3, y3)))
                {
                    result1.Text = "Треугольник построить можно";
                }
                else
                {
                    result1.Text = "Треугольник построить невозмоно";
                }
            }
            else { result1.Text = "Вы ввели что-то не то"; }  
        }
        void f(double x, out double y)
        {
            if (x < 3)
            {
                y = x * x - 0.3;
            }
            else if (x >= 3 && x <= 5)
            {
                y = 0;
            }
            else
            {
                y = x * x;
            }
        }
        double f(double x)
        {
            if (x < 3)
            {
                return x * x - 0.3;
            }
            else if (x >= 3 && x <= 5)
            {
                return 0;
            }
            else
            {
                return x * x;
            }
        }
        double f(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
        bool t(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, h;
            richTextBox1.Text = "";
            if (double.TryParse(textBox7.Text, out a) && double.TryParse(textBox8.Text, out b) && double.TryParse(textBox9.Text, out h))
            {
                for (double x = a; x <= b; x += h)
                {
                    richTextBox1.Text += "x = " + x + "; y = " + f(x) + "\n";
                }
            }
            else 
            {
                richTextBox1.Text = "Вы ввели что-то не то";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, h;
            richTextBox1.Text = "";
            if (double.TryParse(textBox7.Text, out a) && double.TryParse(textBox8.Text, out b) && double.TryParse(textBox9.Text, out h))
            {
                for (double x = a; x <= b; x += h)
                {
                    double y;
                    f(x, out y);
                    richTextBox1.Text += "x = " + x + "; y = " + y + "\n";
                }
            }
            else
            {
                richTextBox1.Text = "Вы ввели что-то не то";
            }
        }
    }
}
