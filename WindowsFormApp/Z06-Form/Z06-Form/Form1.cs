using System;
using System.Windows.Forms;

namespace Z06_Form
{
    public partial class Form1 : Form
    {
		enum ArrayD
		{
			OneD,
			TwoD
		}
		ArrayD arrayDimension;
        public Form1()
        {
            InitializeComponent();
			arrayDimension = ArrayD.OneD;
			toolTip1.SetToolTip(this.richTextBox1, "Пример заполнения одномерного массива\n1 2 3 4\nПример заполнения двумерного массива\n1 2\n3 4");
			toolTip1.SetToolTip(this.richTextBox3, "Пример заполнения последовательнсоти\n1 2 3 4");
			toolTip1.SetToolTip(this.richTextBox4, "Пример заполнения двумерного массива\n1 2\n3 4");
			toolTip1.SetToolTip(this.richTextBox6, "Пример заполнения двумерного массива\n1 2\n3 4");
		}
		int[] Input1D(RichTextBox RTB, TextBox TB)
		{
			try
			{
				int n = int.Parse(TB.Text);
				int[] mas = new int[n];
				string[] strmas = RTB.Text.Split(' ');
				for (int i = 0; i < mas.Length; i++)
				{
					mas[i] = int.Parse(strmas[i]);
				}
				return mas;
			}
			catch (Exception ex)
			{
				RTB.Text += "\n" + ex.Message;
			}
			return null;
		}
		int[,] Input2D(RichTextBox RTB, TextBox TB1, TextBox TB2)
		{
			try
			{
				int row = int.Parse(TB1.Text);
				int col = int.Parse(TB2.Text);
				int[,] mas = new int[row, col];
				string[] strmas = RTB.Text.Split('\n');
				for (int i = 0; i < mas.GetLength(0); i++)
				{
					string[] bufstr = strmas[i].Split(' ');
					for (int j = 0; j < mas.GetLength(1); j++)
					{
						mas[i, j] = int.Parse(bufstr[j]);
					}
				}
				return mas;
			}
			catch (Exception ex)
			{
				RTB.Text += "\n" + ex.Message;
			}
			return null;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label2.Text = "Введите количество элементов: ";
			label2.Visible = true;
			textBox1.Visible = true;
			textBox2.Visible = false;
			label3.Visible = false;
			arrayDimension = ArrayD.OneD;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			label2.Text = "Введите количество строк: ";
			label2.Visible = true;
			label3.Text = "Введите количество столбцов: ";
			label3.Visible = true;
			textBox1.Visible = true;
			textBox2.Visible = true;
			arrayDimension = ArrayD.TwoD;
		}
		private void button3_Click(object sender, EventArgs e)
		{
			if (arrayDimension == ArrayD.OneD)
			{
				int[] mas = Input1D(richTextBox1, textBox1);
				if (mas != null) 
				{
					richTextBox2.Text = "";
					for (int i = 0; i < mas.Length; i++)
					{
						if (i % 2 == 0)
						{
							richTextBox2.Text += mas[i] + " ";
						}
					}
				}
				
			}
			else 
			{
				int[,] mas = Input2D(richTextBox1, textBox1, textBox2);
				if (mas != null)
				{
					richTextBox2.Text = "";
					for (int i = 0; i < mas.GetLength(0); i++)
					{
						for (int j = 0; j < mas.GetLength(1); j++)
						{
							if ((i + j) % 2 == 0)
							{
								richTextBox2.Text += mas[i, j] + " ";
							}
						}
					}
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int[] mas = Input1D(richTextBox3, textBox3);
			if(mas != null) 
			{
				int count = 0;
				for (int i = 0; i < mas.Length - 1; i++)
				{
					if (mas[i] % mas[i + 1] == 0)
					{
						count++;
					}
				}
				result1.Text = "Количество пар соседних элементов, в которых предыдущий элемент кратен последующему: ";
				result1.Text += count;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int[,] mas = Input2D(richTextBox4, textBox4, textBox5);
			if (mas != null) 
			{
				for (int i = 0; i < mas.GetLength(0); i++)
				{
					int max = mas[i, 0];
					for (int j = 0; j < mas.GetLength(1); j++)
					{
						if (mas[i, j] > max)
						{
							max = mas[i, j];
						}
					}
					for (int j = 0; j < mas.GetLength(1); j++)
					{
						if (mas[i, j] == max)
						{
							mas[i, j] = -max;
						}
					}
				}
				richTextBox5.Text = "";
				for (int i = 0; i < mas.GetLength(0); i++)
				{
					for (int j = 0; j < mas.GetLength(1); j++)
					{
						richTextBox5.Text += mas[i, j] + " ";
					}
					richTextBox5.Text += "\n";
				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int[,] mas2D = Input2D(richTextBox6, textBox6, textBox7);
			if (mas2D != null) 
			{
				int[] mas = new int[mas2D.GetLength(0)];
				for (int i = 0; i < mas2D.GetLength(0); i++)
				{
					for (int j = 0; j < mas2D.GetLength(1) - 1; j++)
					{
						if (mas2D[i, j] != mas2D[i, j + 1])
						{
							mas[i] = j;
							break;
						}
					}
				}
				richTextBox7.Text = "";
				for (int i = 0; i < mas.Length; i++)
				{
					richTextBox7.Text += mas[i] + "\n";
				}
			}
		}
	}
}