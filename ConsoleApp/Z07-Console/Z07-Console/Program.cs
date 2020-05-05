using System;
using System.IO;
using System.Text;

namespace Z07_Console
{
    class Program
    {
        //static void Main(string[] args)//Задание 1
        //{
        //    string s = Console.ReadLine();
        //    int firstComma = s.IndexOf(',');
        //    int deleteStrLenght = 0;
        //    do
        //    {
        //        deleteStrLenght++;

        //    } while (s[firstComma + deleteStrLenght] != ',');
        //    s = s.Remove(firstComma, ++deleteStrLenght);
        //    Console.WriteLine(s);
        //}
        static void Main(string[] args)//Задание 2
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < message.Length;)
            {
                if (char.IsPunctuation(message[i]))
                {
                    message.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }
            string[] s = message.ToString().Split(' ');
            Array.Sort(s);
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
