using System;

namespace Z05_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, b, h;
			try
			{
				Console.Write("Введите нижнюю границу: ");
				a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите верхнюю границу: ");
				b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите шаг: ");
				h = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Таблица значений функции");
				for (double x = a; x <= b; x += h)
				{
					Console.WriteLine(x + "; " + f(x));
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		static double f(double x) 
		{
			return Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
		}
	}
}
