using System;
using System.IO;

namespace Z09_Console
{
	class Program
	{
		static void Main(string[] args)//Задание 1
		{
			string s = "Набор слов которые забудтся как слезы в дожде";
			string[] strmas = s.Split(' ');
			BinaryWriter writer = new BinaryWriter(File.Open("file.dat", FileMode.OpenOrCreate));
			for (int i = 0; i < strmas.Length; i++) 
			{
				writer.Write(strmas[i]);
			}
			writer.Close();
			BinaryReader reader = new BinaryReader(File.Open("file.dat", FileMode.Open));
			while (reader.PeekChar() > -1) 
			{
				string buf = reader.ReadString();
				if (buf[0] == buf[buf.Length - 1]) 
				{
					Console.WriteLine(buf);
				}
			}
			reader.Close();
		}
		//static void Main(string[] args)//Задание 2
		//{
		//    string[] s = File.ReadAllLines("text1.txt");
		//    File.WriteAllText("text2.txt", "");
		//    for (int i = 0; i < s.Length; i++) 
		//    {
		//        if (s[i].Length % 2 == 0) 
		//        {
		//            File.AppendAllText("text2.txt", s[i] + "\n");
		//        }
		//    }
		//}
	}
}
