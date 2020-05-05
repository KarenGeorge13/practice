using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z12_Form
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
			line = new StringBuilder("");
			n = 0;

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
		public char this[int i]
		{
			get
			{
				return line[i];
			}
			set
			{
				line[i] = value;
			}
		}
		public static WorkWithString operator +(WorkWithString work)
		{
			for (int i = 0; i < work.n; i++)
			{
				work.line[i] = char.ToUpper(work.line[i]);
			}
			return work;
		}
		public static WorkWithString operator -(WorkWithString work)
		{
			for (int i = 0; i < work.n; i++)
			{
				work.line[i] = char.ToLower(work.line[i]);
			}
			return work;
		}
		public static bool operator true(WorkWithString work)
		{
			if ((string)work == "")
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public static bool operator false(WorkWithString work)
		{
			if ((string)work == "")
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public static bool operator &(WorkWithString work1, WorkWithString work2)
		{
			int size;
			if (work1.n > work2.n)
			{
				size = work1.n;
			}
			else
			{
				size = work2.n;
			}
			for (int i = 0; i < size; i++)
			{
				if (char.ToLower(work1.line[i]) != char.ToLower(work2.line[i]))
				{
					return false;
				}
			}
			return true;
		}
		public static explicit operator string(WorkWithString work)
		{
			return work.line.ToString();
		}
		public static explicit operator WorkWithString(string str)
		{
			return new WorkWithString(str.ToCharArray());
		}
	}
}
