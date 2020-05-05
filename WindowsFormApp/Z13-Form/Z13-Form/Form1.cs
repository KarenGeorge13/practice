using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Z13_Form
{
    public partial class Form1 : Form
    {
		private TelephoneDirectory[] telephoneDirectory;
		private string path;
        public Form1()
        {
            InitializeComponent();
			path = "data.txt";
			//SaveInFile(path);
			ReadFromFile(path);
			OutputList();
		}
		void SaveInFile(string path)
		{
			TelephoneDirectory[] telephoneDirectory = new TelephoneDirectory[3];
			telephoneDirectory[0] = new Person("Георгиевский", "Владимир", "+7(800)555-35-35");
			telephoneDirectory[1] = new Friend("Анисимов", "Владимир", "+7(800)555-35-35", "12.03.2001");
			telephoneDirectory[2] = new Organization("Intel", "Георгиевский", "Владимир", "+7(800)555-35-35", "3255855");
			string[] strmas = new string[telephoneDirectory.Length];
			for (int i = 0; i < telephoneDirectory.Length; i++)
			{
				strmas[i] = telephoneDirectory[i].GetType().ToString() + " " + telephoneDirectory[i].ToString();
			}
			File.WriteAllLines(path, strmas);
		}
		private void button1_Click(object sender, EventArgs e)
        {
			richTextBox2.Text = "";
			string searchFamily = textBox1.Text;
			foreach (TelephoneDirectory tD in telephoneDirectory)
			{
				if (tD.MatchByFamily(searchFamily) != null)
				{
					richTextBox2.Text += tD.OutputNote() + "\n";
				}
			}
		}
		void ReadFromFile(string path)
		{
			string[] strmas = File.ReadAllLines(path);

			telephoneDirectory = new TelephoneDirectory[strmas.Length];
			for (int i = 0; i < strmas.Length; i++)
			{
				string[] bufstr = strmas[i].Split(' ');
				string type = bufstr[0];
				if (type == new Person().GetType().ToString())
				{
					telephoneDirectory[i] = new Person(bufstr[1], bufstr[2], bufstr[3]);
				}
				if (type == new Organization().GetType().ToString())
				{
					telephoneDirectory[i] = new Organization(bufstr[1], bufstr[2], bufstr[3], bufstr[4], bufstr[5]);
				}
				if (type == new Friend().GetType().ToString())
				{
					telephoneDirectory[i] = new Friend(bufstr[1], bufstr[2], bufstr[3], bufstr[4]);
				}
			}
		}
		void OutputList() 
		{
			richTextBox1.Text = "";
			foreach (TelephoneDirectory tD in telephoneDirectory)
			{
				richTextBox1.Text += tD.OutputNote() + "\n";
			}
		}
	}
}
