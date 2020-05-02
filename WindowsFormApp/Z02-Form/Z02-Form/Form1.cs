using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z02_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap("graph.png");
            TextBoxFill();
        }

        void TextBoxFill() 
        {
            int i = 101;
            richTextBox2.Text = "Вывод с помощью цикла while:\n";
            int curNum = i + 90;
            while (i < 1000)
            {
                richTextBox2.Text += i + " ";
                i += 10;
                if (i > curNum)
                {
                    i += 1;
                    curNum = i + 90;
                }
            }

            richTextBox2.Text += "\nВывод с помощью цикла do while:\n";
            i = 101;
            curNum = i + 90;
            do
            {
                richTextBox2.Text += i + " ";
                i += 10;
                if (i > curNum)
                {
                    i += 1;
                    curNum = i + 90;
                }
            } while (i < 1000);

            richTextBox2.Text += "\nВывод с помощью цикла for:\n";
            for (int j = 101; j < 1000; j += 1)
            {
                for (int cur = j + 90; j <= cur; j += 10)
                {
                    richTextBox2.Text += j + " ";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            const double R = 10;
            double x, y;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y)) 
            {
                result1.Text = "resfggf";
                if (x * x + y * y <= R * R)
                {
                    if (((x - y) > 0 || (x + y) > 0) && y > 0)
                    {
                        result1.Text = "Точка лежит вне закрашенной области";
                    }
                    else
                    {
                        if (x * x + y * y == R * R || (x - y) == 0 || (x + y) == 0)
                        {
                            result1.Text = "Точка лежит на границе закрашенной области";
                        }
                        else
                        {
                            result1.Text = "Точка лежит внутри закрашенной области";

                        }
                    }
                }
                else
                {
                    result1.Text = "Точка лежит вне закрашенной области";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chanel;
            int.TryParse(textBox3.Text, out chanel);
            richTextBox1.Text = "Наиболее популярные программы канала №" + chanel + ":\n";
            switch (chanel)
            {
                case 1:
                    richTextBox1.Text += "Пусть говорят\nЖить здорово\n";
                    break;
                case 2:
                    richTextBox1.Text += "Вести \nБитва хороd\n";
                    break;
                case 3:
                    richTextBox1.Text += "Час суда\nМухтар\n";
                    break;
                case 4:
                    richTextBox1.Text += "Военная тайна\nСлед\n";
                    break;
                default:
                    richTextBox1.Text += "У выбранного канала нет популярных программ\n";
                    break;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            int[] mas = new int[n * 2];
            mas[0] = 3;
            mas[1] = 0;
            for (int i = 2, j = 9; i < mas.Length; i++)
            {
                if (i % 2 == 0)
                {
                    mas[i] = 2;
                }
                else
                {
                    mas[i] = j;
                    j--;
                }
            }

            richTextBox3.Text = "";    
            int fillCount = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 == 0)
                {
                    fillCount++;
                }
                string curStr = "";
                for (int j = 0; j < fillCount; j++)
                {
                    curStr += mas[i - j * 2] + "  ";
                }
                richTextBox3.Text += curStr + "\n";
            }
        }
    }
}
