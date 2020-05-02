using System;

namespace Z03_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x1, x2, x3, y1, y2, y3;
            //Console.WriteLine("Введите координаты точки 1");
            //Console.Write("X: ");
            //double.TryParse(Console.ReadLine(), out x1);
            //Console.Write("Y: ");
            //double.TryParse(Console.ReadLine(), out y1);
            //Console.WriteLine("Введите координаты точки 2");
            //Console.Write("X: ");
            //double.TryParse(Console.ReadLine(), out x2);
            //Console.Write("Y: ");
            //double.TryParse(Console.ReadLine(), out y2);
            //Console.WriteLine("Введите координаты точки 3");
            //Console.Write("X: ");
            //double.TryParse(Console.ReadLine(), out x3);
            //Console.Write("Y: ");
            //double.TryParse(Console.ReadLine(), out y3);
            //if (t(f(x1, y1, x2, y2), f(x1, y1, x3, y3), f(x2, y2, x3, y3)))
            //{
            //    Console.WriteLine("Треугольник построить можно");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольник построить невозмоно");
            //}

            double a, b, h;

            double.TryParse(Console.ReadLine(), out a);

            double.TryParse(Console.ReadLine(), out b);

            double.TryParse(Console.ReadLine(), out h);

            for (double x = a; x <= b; x += h) 
            {
                Console.WriteLine("x = " + x + "; y = " + f(x));
            }
            for (double x = a; x <= b; x += h)
            {
                double y;
                f(x, out y);
                Console.WriteLine("x = " + x + "; y = " + y);
            }
        }
        static void f(double x, out double y)
        {
            if (x < 3)
            {
                y =  x * x - 0.3;
            }
            else if (x >= 3 && x <= 5)
            {
                y = 0;
            }
            else
            {
                y =  x * x;
            }
        }
        static double f(double x) 
        {
            if (x < 3)
            {
                return x * x - 0.3;
            }
            else if (x >= 3 && x <= 5)
            {
                return 0;
            }
            else
            {
                return x * x;
            }
        }
        static double f(double x1, double y1, double x2, double y2) 
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
        static bool t(double a, double b, double c) 
        {
            if (a + b < c || a + c < b || b + c < a) 
            {
                return false;
            }
            return true;
        }
    }
}
