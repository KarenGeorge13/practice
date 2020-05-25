using System;
using System.IO;

namespace Z13_Console
{
	class Program
	{
		static void Main(string[] args)
		{ 
			//Вывод информации
			string path = "data.txt";
			SaveInFile(path);
			TelephoneDirectory[] telephoneDirectories;
			ReadFromFile(path, out telephoneDirectories);
			Console.WriteLine("Информация о всех записях: ");
			foreach (TelephoneDirectory tD in telephoneDirectories)
			{
				Console.WriteLine(tD.OutputNote());
			}
			Console.WriteLine("Информация о записях с фамилией \"Георгиевский\":");
			foreach (TelephoneDirectory tD in telephoneDirectories)
			{
				if (tD.MatchByFamily("Георгиевский") != null)
				{
					Console.WriteLine(tD.OutputNote());
				}
			}
		}
		static void SaveInFile(string path) //Приведено для понимания организации хранения объектов в файле
		{
			TelephoneDirectory[] telephoneDirectory = new TelephoneDirectory[3];
			telephoneDirectory[0] = new Person("Георгиевский", "Владимир", "+7(800)555-35-35");
			telephoneDirectory[1] = new Friend("Анисимов", "Владимир", "+7(800)555-35-35", "12.03.2001");
			telephoneDirectory[2] = new Organization("Intel", "Георгиевский", "Владимир", "+7(800)555-35-35", "3255855");
			string[] strmas = new string[telephoneDirectory.Length];
			for (int i = 0; i < telephoneDirectory.Length; i++)
			{
				strmas[i] = telephoneDirectory[i].GetType().ToString() + " " + telephoneDirectory[i].ToString();
			}
			File.WriteAllLines(path, strmas);
		}
		static void ReadFromFile(string path, out TelephoneDirectory[] telephoneDirectories) 
		{
			string[] strmas = File.ReadAllLines(path);
			telephoneDirectories = new TelephoneDirectory[strmas.Length];
			for (int i = 0; i < strmas.Length; i++)
			{
				string[] bufstr = strmas[i].Split(' ');
				string type = bufstr[0];
				if (type == new Person().GetType().ToString())
				{
					telephoneDirectories[i] = new Person(bufstr[1], bufstr[2], bufstr[3]);
				}
				if (type == new Organization().GetType().ToString())
				{
					telephoneDirectories[i] = new Organization(bufstr[1], bufstr[2], bufstr[3], bufstr[4], bufstr[5]);
				}
				if (type == new Friend().GetType().ToString())
				{
					telephoneDirectories[i] = new Friend(bufstr[1], bufstr[2], bufstr[3], bufstr[4]);
				}
			}
		}
	}
}
