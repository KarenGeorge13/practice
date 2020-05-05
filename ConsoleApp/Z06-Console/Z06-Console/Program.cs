using System;

namespace Z06_Console
{
	class Program
	{
		//static void Main(string[] args)//Задание 1
		//{
		//	int[] mas1D = Input1D();
		//	for (int i = 0; i < mas1D.Length; i++)
		//	{
		//		if (i % 2 == 0)
		//		{
		//			Console.WriteLine(mas1D[i]);
		//		}
		//	}
		//	int[,] mas2D = Input2D();
		//	for (int i = 0; i < mas2D.GetLength(0); i++)
		//	{
		//		for (int j = 0; j < mas2D.GetLength(1); j++)
		//		{
		//			if ((i + j) % 2 == 0)
		//			{
		//				Console.WriteLine(mas2D[i, j]);
		//			}
		//		}
		//	}
		//}
		//static void Main(string[] args)//Задание 2
		//{
		//	int[] mas = Input1D();
		//	int count = 0;
		//	for (int i = 0; i < mas.Length - 1; i++)
		//	{
		//		if (mas[i] % mas[i + 1] == 0)
		//		{
		//			count++;
		//		}
		//	}
		//	Console.WriteLine(count);
		//}
		//static void Main(string[] args)//Задание 3
		//{
		//	int[,] mas = Input2D();
		//	for (int i = 0; i < mas.GetLength(0); i++)
		//	{
		//		int max = mas[i, 0];
		//		for (int j = 0; j < mas.GetLength(1); j++)
		//		{
		//			if (mas[i, j] > max)
		//			{
		//				max = mas[i, j];
		//			}
		//		}
		//		for (int j = 0; j < mas.GetLength(1); j++)
		//		{
		//			if (mas[i, j] == max)
		//			{
		//				mas[i, j] = -max;
		//			}
		//		}
		//	}
		//	for (int i = 0; i < mas.GetLength(0); i++)
		//	{
		//		for (int j = 0; j < mas.GetLength(1); j++)
		//		{
		//			Console.Write(mas[i, j]);
		//		}
		//		Console.WriteLine();
		//	}
		//}
		static void Main(string[] args) //Задание 4
		{
			int[,] mas2D = Input2D();
			int[] mas = new int[mas2D.GetLength(0)];
			for (int i = 0; i < mas2D.GetLength(0); i++)
			{
				for (int j = 0; j < mas2D.GetLength(1) - 1; j++)
				{
					if (mas2D[i, j] != mas2D[i, j + 1])
					{
						mas[i] = j;
						break;
					}
				}
			}
			for (int i = 0; i < mas.Length; i++)
			{
				Console.WriteLine(mas[i]);
			}
		}
		static int[] Input1D() 
		{
			Console.Write("Введите количество элементов: ");
			int n = int.Parse(Console.ReadLine());
			int[] mas = new int[n];
			for (int i = 0; i < mas.Length; i++) 
			{
				mas[i] = int.Parse(Console.ReadLine());
			}
			return mas;
		}
		static int[,] Input2D()
		{
			Console.Write("Введите количество строк: ");
			int row = int.Parse(Console.ReadLine());
			Console.Write("Введите количество столбцов: ");
			int col = int.Parse(Console.ReadLine());
			int[,] mas = new int[row, col];
			for (int i = 0; i < mas.GetLength(0); i++)
			{
				for (int j = 0; j < mas.GetLength(1); j++) 
				{
					mas[i, j] = int.Parse(Console.ReadLine());
				}    
			}
			return mas;
		}

	}
}
