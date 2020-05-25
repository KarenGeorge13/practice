using System;
using System.Text;
using System.Windows.Forms;

namespace Z11_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkWithString str = new WorkWithString(); 
            str.Line = new StringBuilder(textBox1.Text);
            textBox2.Text = str.n.ToString();
            textBox3.Text = str.SpaceCount().ToString();
            str.ToLower();
            textBox4.Text = str.Line.ToString();
            str.RemovePunctuation();
            textBox5.Text = str.Line.ToString();
        }
    }
}
