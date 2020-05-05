using System;
using System.Text;

namespace Z11_Console
{
	class WorkWithString
	{
		private StringBuilder line;
		public StringBuilder Line
		{
			get
			{
				return line;
			}
			set
			{
				line = value;
				n = line.Length;
			}
		}
		public int n { get; private set; }

		public WorkWithString()
		{
			n = 0;
			line = new StringBuilder("");
		}
		public WorkWithString(char[] mas)
		{
			n = mas.Length;
			line = new StringBuilder(new string(mas));
		}
		public int SpaceCount()
		{
			int count = 0;
			for (int i = 0; i < n; i++)
			{
				if (line[i] == ' ')
				{
					count++;
				}
			}
			return count;
		}
		public void ToLower()
		{
			for (int i = 0; i < n; i++)
			{
				if (char.IsUpper(line[i]))
				{
					line[i] = char.ToLower(line[i]);
				}
			}
		}
		public void RemovePunctuation()
		{
			for (int i = 0; i < n;)
			{
				if (char.IsPunctuation(line[i]))
				{
					line.Remove(i, 1);
					n--;
				}
				else
				{
					i++;
				}
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			WorkWithString work = new WorkWithString(s.ToCharArray());
			Console.WriteLine(work.SpaceCount());
			work.ToLower();
			Console.WriteLine(work.Line);
			work.RemovePunctuation();
			Console.WriteLine(work.Line);
			Console.WriteLine(work.n);
			work.Line = new StringBuilder(Console.ReadLine());
			Console.WriteLine(work.Line);
		}
	}
}
