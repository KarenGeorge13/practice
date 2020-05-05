using System;

namespace Z04_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			int m, k;
			Console.Write("Введите m: ");
			int.TryParse(Console.ReadLine(), out m);
			Console.Write("Введите k: ");
			int.TryParse(Console.ReadLine(), out k);
			Console.WriteLine(sum(m) + sum(2 * k));
			int n;
			Console.Write("Введите n: ");
			int.TryParse(Console.ReadLine(), out n);
			Console.WriteLine("Числа не больше, чем " + n);
			OutLessThenN(n);
		}
		static void OutLessThenN(int n, int i = 1)
		{
			Console.Write(i + " ");
			if (i == n) 
			{
				return;
			}
			OutLessThenN(n, ++i);
		}
		static int sum(int n, int i = 1) 
		{
			if (i == n) 
			{
				return i;
			}
			return i + sum(n, ++i);
		}
	}
}
