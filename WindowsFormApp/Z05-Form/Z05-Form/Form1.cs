using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z05_Form
{
    public partial class Form1 : Form
    {
		public Form1()
		{
			InitializeComponent();
			pictureBox1.Image = new Bitmap("func.png");
		}
        double f(double x)
        {
            return Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			double a, b, h;
			try
			{
				a = Convert.ToDouble(textBox1.Text);
				b = Convert.ToDouble(textBox2.Text);
				h = Convert.ToDouble(textBox3.Text);
				richTextBox1.Text = "Таблица значений функции:\n";
				for (double x = a; x <= b; x += h)
				{
					richTextBox1.Text += x.ToString("0.####") + "; " + f(x).ToString("0.0000") + "\n";
				}
			}
			catch (Exception ex)
			{
				richTextBox1.Text = ex.Message;
			}
		}
	}
}
