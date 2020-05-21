using System;
using System.Windows.Forms;
using System.IO;

namespace Z10_Form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try 
			{
				string dir1name = textBox1.Text;
				string dir2name = textBox2.Text;
				Directory.CreateDirectory(@"C:\temp\" + dir1name);
				Directory.CreateDirectory(@"C:\temp\" + dir2name);

				string s1 = textBox1.Text;
				string s2 = textBox2.Text;
				File.WriteAllText(@"C:\temp\" + dir1name + @"\t1.txt", s1);
				File.WriteAllText(@"C:\temp\" + dir1name + @"\t2.txt", s2);

				File.WriteAllText(@"C:\temp\" + dir2name + @"\t3.txt", File.ReadAllText(@"C:\temp\" + dir1name + @"\t1.txt"));
				File.AppendAllText(@"C:\temp\" + dir2name + @"\t3.txt", File.ReadAllText(@"C:\temp\" + dir1name + @"\t2.txt"));

				FileInfo[] files = new FileInfo[3];
				files[0] = new FileInfo(@"C:\temp\" + dir1name + @"\t1.txt");
				files[1] = new FileInfo(@"C:\temp\" + dir1name + @"\t2.txt");
				files[2] = new FileInfo(@"C:\temp\" + dir1name + @"\t3.txt");
				foreach (FileInfo fileInfo in files)
				{
					richTextBox1.Text += "Полное имя файла: " + fileInfo.FullName + "\n";
					richTextBox1.Text += "Расширение файла: " + fileInfo.Extension + "\n";
					richTextBox1.Text += "Время создания" + fileInfo.CreationTime + "\n";
				}

				File.Move(@"C:\temp\" + dir1name + @"\t2.txt", @"C:\temp\" + dir2name + @"\t2.txt");
				File.Copy(@"C:\temp\" + dir1name + @"\t1.txt", @"C:\temp\" + dir2name + @"\t1.txt");

				Directory.Move(@"C:\temp\" + dir2name, @"C:\temp\ALL");
				Directory.Delete(@"C:\temp\" + dir1name, true);
				files = new DirectoryInfo(@"C:\temp\ALL").GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					richTextBox2.Text += "Полное имя файла: " + fileInfo.FullName + "\n";
					richTextBox2.Text += "Расширение файла: " + fileInfo.Extension + "\n";
					richTextBox2.Text += "Время создания" + fileInfo.CreationTime + "\n";
				}
			}
			catch(Exception ex)
			{
				richTextBox2.Text = ex.Message;
			}
		}
	}
}
