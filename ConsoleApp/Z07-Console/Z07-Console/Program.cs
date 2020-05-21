using System;
using System.Linq;
using System.Text;

namespace Z07_Console
{
    class Program
    {
        //static void Main(string[] args)//Задание 1
        //{
        //    Console.Write("Введите исходную строку: ");
        //    string s = Console.ReadLine();
        //    int firstComma = s.IndexOf(',');
        //    int deleteStrLenght = 0;
        //    do
        //    {
        //        deleteStrLenght++;

        //    } while (s[firstComma + deleteStrLenght] != ',');
        //    s = s.Remove(firstComma, deleteStrLenght);
        //    Console.WriteLine("Отредактированная строка: " + s);
        //}
        static void Main(string[] args)//Задание 2
        {
            Console.Write("Введите исходную строку: ");
            StringBuilder message = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < message.Length;)
            {
                if (char.IsPunctuation(message[i]))
                {
                    message.Replace(message[i], ' ');
                }
                else
                {
                    i++;
                }
            }
            string[] s = message.ToString().Split(' ');
            s = s.Where(item => item != "").ToArray();
            Array.Sort(s);
            Console.WriteLine("Слова сообщения в алфавитном порядке:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
