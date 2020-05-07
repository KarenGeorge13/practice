using System;
using System.Windows.Forms;

namespace Z01_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstMember, difference;
            int n;
            if (double.TryParse(textBox1.Text, out firstMember) && double.TryParse(textBox2.Text, out difference) && int.TryParse(textBox3.Text, out n))
            {
                double sum = (firstMember * 2 + difference * (n - 1)) / 2 * n;
                result1.Text = sum.ToString();
            }
            else 
            {
                result1.Text = "Вы ввели что-то не то";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double side1, side2, side3;
            if (double.TryParse(textBox4.Text, out side1) && double.TryParse(textBox5.Text, out side2) && double.TryParse(textBox6.Text, out side3))
            {
                if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    result2.Text = "Треугольник равнобедренный";
                }
                else
                {
                    result2.Text = "Треугольник не равнобедренный";
                }
            }
            else
            {
                result2.Text = "Вы ввели что-то не то";
            }
        }
    }
}
