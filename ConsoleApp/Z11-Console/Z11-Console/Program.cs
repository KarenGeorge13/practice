using System;
using System.Text;

namespace Z11_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			WorkWithString work = new WorkWithString();
			work.Line = new StringBuilder(Console.ReadLine());
			Console.WriteLine("Количество символов в строке: " + work.n);
			Console.WriteLine("Количество пробелов в строке: " + work.SpaceCount());
			work.ToLower();
			Console.WriteLine("Строка из строчных символов: " + work.Line);
			work.RemovePunctuation();
			Console.WriteLine("Строка с удаленными знаками препинания: " + work.Line);
		}
	}
}
