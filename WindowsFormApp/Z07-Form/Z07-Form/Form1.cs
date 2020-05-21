using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Z07_Form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string s = textBox1.Text;
			int firstComma = s.IndexOf(',');
			try
			{
				if (firstComma < 0) 
				{
					throw new Exception();
				}
				int deleteStrLenght = 0;
				do
				{
					deleteStrLenght++;

				} while (s[firstComma + deleteStrLenght] != ',');
				s = s.Remove(firstComma, deleteStrLenght);
				textBox2.Text = s;
			}
			catch (Exception ex)
			{
				textBox2.Text = "В тексте должно быть ровно две запятых";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			StringBuilder message = new StringBuilder(textBox3.Text);

			for (int i = 0; i < message.Length;)
			{
				if (char.IsPunctuation(message[i]))
				{
					message.Replace(message[i], ' ');
				}
				else
				{
					i++;
				}
			}
			string[] s = message.ToString().Split(' ');
			s = s.Where(item => item != "").ToArray();
			Array.Sort(s);
			richTextBox1.Text = "";
			for (int i = 0; i < s.Length; i++)
			{
				richTextBox1.Text += s[i] + "\n";
			}
		}
	}
}
