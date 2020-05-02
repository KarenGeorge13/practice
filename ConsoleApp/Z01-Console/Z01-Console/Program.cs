using System;

namespace Z01_Console
{
    class Program
    {
        //static void Main(string[] args) //Задание 1
        //{
        //    Console.Write("Введите первый член: ");
        //    double firstMember = Convert.ToDouble(Console.ReadLine());

        //    Console.Write("Введите разность: ");
        //    double difference = Convert.ToDouble(Console.ReadLine());

        //    Console.Write("Введите количество членов: ");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    double sum = (firstMember * 2 + difference * (n - 1)) / 2 * n;
        //    Console.WriteLine(sum);
        //}


        static void Main(string[] args) //Задание 2
        {
            Console.Write("Введите длину стороны 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());
            if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Треугольник равнобедренный)");
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный(");
            }
        }
    }
}
