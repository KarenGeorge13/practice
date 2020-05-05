using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Z09_Form
{
    public partial class Form1 : Form
    {
        private string fileName;
        private string textFileName;
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.richTextBox1, "Вводите каждое слово с новой строчки\nПример заполнения:\nслово1\nслово2");
            fileName = "file.dat";
            textFileName = "text.txt";
            richTextBox3.Text = File.ReadAllText(textFileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = richTextBox1.Text;
            if (textBox1.Text != "") 
            {
                fileName = textBox1.Text + ".dat";
            }
            string[] strmas = s.Split('\n');
            BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate));
            for (int i = 0; i < strmas.Length; i++)
            {
                writer.Write(strmas[i]);
            }
            writer.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open));
            richTextBox2.Text += "";
            while (reader.PeekChar() > -1)
            {
                string buf = reader.ReadString();
                if (buf[0] == buf[buf.Length - 1])
                {
                    richTextBox2.Text += buf + "\n";
                }
            }
            reader.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string[] s = File.ReadAllLines(textFileName);
            string saveTextFileName = textBox2.Text + ".txt";
            File.WriteAllText(saveTextFileName, "");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length % 2 == 0)
                {
                    File.AppendAllText(saveTextFileName, s[i] + "\n");
                }
            }
            richTextBox4.Text = File.ReadAllText(saveTextFileName);
        }
    }
}
