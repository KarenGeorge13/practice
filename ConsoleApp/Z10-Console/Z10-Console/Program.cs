using System;
using System.IO;

namespace Z10_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\temp\K1");
            Directory.CreateDirectory(@"C:\temp\K2");

            string s1 = "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов";
            string s2 = "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс";
            File.WriteAllText(@"C:\temp\K1\t1.txt", s1);
            File.WriteAllText(@"C:\temp\K1\t2.txt", s2);

            File.WriteAllText(@"C:\temp\K2\t3.txt", File.ReadAllText(@"C:\temp\K1\t1.txt"));
            File.AppendAllText(@"C:\temp\K2\t3.txt", File.ReadAllText(@"C:\temp\K1\t2.txt"));

            FileInfo[] files = new FileInfo[3];
            files[0] = new FileInfo(@"C:\temp\K1\t1.txt");
            files[1] = new FileInfo(@"C:\temp\K1\t2.txt");
            files[2] = new FileInfo(@"C:\temp\K2\t3.txt");
            Console.WriteLine("Информация о созданных файлах");
            foreach (FileInfo fileInfo in files) 
            {
                Console.WriteLine("Полное имя файла: " + fileInfo.FullName);
                Console.WriteLine("Расширение файла: " + fileInfo.Extension);
                Console.WriteLine("Время создания" + fileInfo.CreationTime);
            }

            File.Move(@"C:\temp\K1\t2.txt", @"C:\temp\K2\t2.txt");
            File.Copy(@"C:\temp\K1\t1.txt", @"C:\temp\K2\t1.txt");

            Directory.Move(@"C:\temp\K2", @"C:\temp\ALL");
            Directory.Delete(@"C:\temp\K1", true);
            files = new DirectoryInfo(@"C:\temp\ALL").GetFiles();
            Console.WriteLine("Информация о файлах папки ALL");
            foreach (FileInfo fileInfo in files)
            {
                Console.WriteLine("Полное имя файла: " + fileInfo.FullName);
                Console.WriteLine("Расширение файла: " + fileInfo.Extension);
                Console.WriteLine("Время создания: " + fileInfo.CreationTime);
            }
        }
    }
}
