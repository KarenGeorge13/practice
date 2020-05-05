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

namespace Z10_Form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Directory.CreateDirectory(@"C:\temp\K1");
			Directory.CreateDirectory(@"C:\temp\K2");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string s1 = textBox1.Text;
			string s2 = textBox2.Text;
			File.WriteAllText(@"C:\temp\K1\t1.txt", s1);
			File.WriteAllText(@"C:\temp\K1\t2.txt", s2);

			File.WriteAllText(@"C:\temp\K2\t3.txt", File.ReadAllText(@"C:\temp\K1\t1.txt"));
			File.AppendAllText(@"C:\temp\K2\t3.txt", File.ReadAllText(@"C:\temp\K1\t2.txt"));

			FileInfo[] files = new FileInfo[3];
			files[0] = new FileInfo(@"C:\temp\K1\t1.txt");
			files[1] = new FileInfo(@"C:\temp\K1\t2.txt");
			files[2] = new FileInfo(@"C:\temp\K2\t3.txt");
			foreach (FileInfo fileInfo in files)
			{
				richTextBox1.Text += "Полное имя файла: " + fileInfo.FullName + "\n";
				richTextBox1.Text += "Расширение файла: " + fileInfo.Extension + "\n";
				richTextBox1.Text += "Время создания" + fileInfo.CreationTime + "\n";
			}
		
			File.Move(@"C:\temp\K1\t2.txt", @"C:\temp\K2\t2.txt");
			File.Copy(@"C:\temp\K1\t1.txt", @"C:\temp\K2\t1.txt");

			Directory.Move(@"C:\temp\K2", @"C:\temp\ALL");
			Directory.Delete(@"C:\temp\K1", true);
			files = new DirectoryInfo(@"C:\temp\ALL").GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				richTextBox2.Text += "Полное имя файла: " + fileInfo.FullName + "\n";
				richTextBox2.Text += "Расширение файла: " + fileInfo.Extension + "\n";
				richTextBox2.Text += "Время создания" + fileInfo.CreationTime + "\n";
			}
		}
	}
}
