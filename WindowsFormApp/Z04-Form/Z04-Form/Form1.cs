using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z04_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap("formula.png");
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            richTextBox1.Text = "";
            OutLessThenN(n);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int m, k;
            result1.Text = "Результат вычислений: ";
            if (int.TryParse(textBox1.Text, out m) & int.TryParse(textBox2.Text, out k)) 
            {
                result1.Text += sum(m) + sum(2 * k);
            }
        }
        int sum(int n, int i = 1)
        {
            if (i == n)
            {
                return i;
            }
            return i + sum(n, ++i);
        }
        void OutLessThenN(int n, int i = 1)
        {
            richTextBox1.Text += i + " ";
            if (i == n)
            {
                return;
            }
            OutLessThenN(n, ++i);
        }
        
    }
}
