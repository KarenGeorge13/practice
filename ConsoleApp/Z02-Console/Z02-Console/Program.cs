using System;

namespace Z02_Console
{
    class Program
    {
        //static void Main(string[] args)//Задание 1
        //{
        //    const double R = 10;

        //    double x, y;
        //    Console.WriteLine("Введите координаты точки");
        //    Console.Write("X: ");
        //    double.TryParse(Console.ReadLine(), out x);
        //    Console.Write("Y: ");
        //    double.TryParse(Console.ReadLine(), out y);

        //    if (x * x + y * y <= R * R)
        //    {
        //        if (((x - y) > 0 || (x + y) > 0) && y > 0)
        //        {
        //            Console.WriteLine("Точка лежит вне закрашенной области");
        //        }
        //        else
        //        {
        //            if (x * x + y * y == R * R || (x - y) == 0 || (x + y) == 0)
        //            {
        //                Console.WriteLine("Точка лежит на границе закрашенной области");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Точка лежит внутри закрашенной области");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Точка лежит вне закрашенной области");
        //    }
        //}


        //static void Main(string[] args) //Задание 2
        //{
        //    int chanel;
        //    Console.Write("Введите желаемый номер канала: ");
        //    int.TryParse(Console.ReadLine(), out chanel);
        //    Console.WriteLine("Наиболее популярные программы канала №" + chanel);
        //    switch (chanel)
        //    {
        //        case 1:
        //            Console.WriteLine("Пусть говорят \nЖить здорово");
        //            break;
        //        case 2:
        //            Console.WriteLine("Вести \nБитва хоров");
        //            break;
        //        case 3:
        //            Console.WriteLine("Час суда \nМухтар");
        //            break;
        //        case 4:
        //            Console.WriteLine("Военная тайна \nСлед");
        //            break;
        //        default:
        //            Console.WriteLine("У выбранного канала нет популярных программ");
        //            break;
        //    }
        //}


        //static void Main(string[] args) //Задание 3
        //{
        //    Console.WriteLine("Цикл while");
        //    int i = 101;
        //    int curNum = i + 90;
        //    while (i < 1000)
        //    {
        //        Console.Write(i + " ");
        //        i += 10;
        //        if (i > curNum)
        //        {
        //            i += 1;
        //            curNum = i + 90;
        //        }
        //    }
        //    Console.WriteLine("\nЦикл do while");
        //    i = 101;
        //    curNum = i + 90;
        //    do
        //    {
        //        Console.Write(i + " ");
        //        i += 10;
        //        if (i > curNum)
        //        {
        //            i += 1;
        //            curNum = i + 90;
        //        }
        //    } while (i < 1000);
        //    Console.WriteLine("\nЦикл for");
        //    for (int j = 101; j < 1000; j += 1)
        //    {
        //        for (int cur = j + 90; j <= cur; j += 10)
        //        {
        //            Console.Write(j + " ");
        //        }
        //    }
        //}


        static void Main(string[] args) //Задание 4
        {
            Console.Write("Введите количество рядов (не больше 10): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 10)
            {
                n = 10;
            }
            int[] mas = new int[n * 2];
            mas[0] = 3;
            mas[1] = 0;
            for (int i = 2, j = 9; i < mas.Length; i++)
            {
                if (i % 2 == 0)
                {
                    mas[i] = 2;
                }
                else
                {
                    mas[i] = j;
                    j--;
                }
            }

            int fillCount = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 == 0)
                {
                    fillCount++;
                }
                string curStr = "";
                for (int j = 0; j < fillCount; j++)
                {
                    curStr += mas[i - j * 2] + "  ";
                }
                Console.WriteLine(curStr);
            }
        }
    }
}
