using System;
using System.Windows.Forms;

namespace Z12_Form
{
	public partial class Form1 : Form
	{
		private WorkWithString str1;
		public Form1()
		{
			InitializeComponent();
			str1 = (WorkWithString)"";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			str1 = (WorkWithString)textBox1.Text;
			textBox3.Text = str1[0] + "" + str1[1] + "" + str1[2];
			textBox4.Text = (string)+str1;
			textBox5.Text = (string)-str1;
			if (str1)
			{
				textBox6.Text = "Строка не пуста";
			}
			else 
			{
				textBox6.Text = "Строка пуста";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			WorkWithString str2 = (WorkWithString)textBox2.Text;
			if (str1 & str2)
			{
				textBox7.Text = "Строки равны";
			}
			else 
			{
				textBox7.Text = "Строки не равны";
			}
		}
	}
}
