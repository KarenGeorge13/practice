using System;
using System.Text;

namespace Z12_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите первую строку: ");
			WorkWithString work = (WorkWithString)Console.ReadLine();
			Console.WriteLine("Первые три символа строки: " + work[0] + "" + work [1] + "" + work[2]);
			Console.WriteLine("ВСЕ ПРОПИСНЫЕ: " + (string)+work);
			Console.WriteLine("все строчные: " + (string)-work);
			work = (WorkWithString)"";
			Console.Write("Есть ли в строке символы: ");
			if (work)
			{
				Console.WriteLine("Строка пустая");
			}
			else 
			{
				Console.WriteLine("Строка не пустая");
			}
			Console.Write("Введите вторую строку: ");
			WorkWithString work2 = (WorkWithString)Console.ReadLine();
			if (work2 & work)
			{
				Console.WriteLine("Строки равны");
			}
			else
			{
				Console.WriteLine("Строки не равны");
			}
		}
	}
}
