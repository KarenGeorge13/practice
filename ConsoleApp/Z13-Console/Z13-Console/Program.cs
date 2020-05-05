using System;
using System.IO;

namespace Z13_Console
{
	abstract class TelephoneDirectory
	{
		public abstract string OutputNote();
		public abstract TelephoneDirectory MatchByFamily(string family);
	}
	class Person :TelephoneDirectory
	{
		private string lastName;
		private string address;
		private string phoneNumber;
		public Person() 
		{
			this.lastName = "";
			this.address = "";
			this.phoneNumber = "";
		}
		public Person(string lastName, string address, string phoneNumber) 
		{
			this.lastName = lastName;
			this.address = address;
			this.phoneNumber = phoneNumber;
		}
		public override string OutputNote()
		{
			string str = "Фамилия: " + lastName + "\n";
			str += "Адрес: " + address + "\n";
			str += "Номер: " + phoneNumber + "\n";
			return str;
		}
		public override TelephoneDirectory MatchByFamily(string family)
		{
			if (family == lastName)
			{
				return this;
			}
			return null;
		}
		public override string ToString()
		{
			string str = lastName + " ";
			str += address + " ";
			str += phoneNumber + " ";
			return str;
		}
	}
	class Friend : TelephoneDirectory
	{
		private string lastName;
		private string address;
		private string phoneNumber;
		private string birthDate;
		public Friend() 
		{
			this.lastName = "";
			this.address = "";
			this.phoneNumber = "";
			this.birthDate = "";
		}
		public Friend(string lastName, string address, string phoneNumber, string birthDate)
		{
			this.lastName = lastName;
			this.address = address;
			this.phoneNumber = phoneNumber;
			this.birthDate = birthDate;
		}
		public override string OutputNote()
		{
			string str = "Фамилия: " + lastName + "\n";
			str += "Адрес: " + address + "\n";
			str += "Номер: " + phoneNumber + "\n";
			str += "Дата рождения: " + birthDate + "\n";
			return str;
		}
		public override TelephoneDirectory MatchByFamily(string family)
		{
			if (family == lastName)
			{
				return this;
			}
			return null;
		}
		public override string ToString()
		{
			string str = lastName + " ";
			str += address + " ";
			str += phoneNumber + " ";
			str += birthDate + " ";
			return str;
		}
	}
	class Organization : TelephoneDirectory 
	{
		private string organizationName;
		private string contactPerson;
		private string address;
		private string phoneNumber;
		private string fax;
		public Organization() 
		{
			this.organizationName = "";
			this.contactPerson = "";
			this.address = "";
			this.phoneNumber = "";
			this.fax = "";
		}
		public Organization(string organizationName, string contactPerson, string address, string phoneNumber, string fax)
		{
			this.organizationName = organizationName;
			this.contactPerson = contactPerson;
			this.address = address;
			this.phoneNumber = phoneNumber;
			this.fax = fax;
		}
		public override string OutputNote()
		{
			string str = "Название организации: " + organizationName + "\n"; 
			str += "Контактное лицо: " + contactPerson + "\n";
			str += "Адрес: " + address + "\n";
			str += "Номер: " + phoneNumber + "\n";
			str += "Дата рождения: " + fax + "\n";
			return str;
		}
		public override TelephoneDirectory MatchByFamily(string family)
		{
			if (family == contactPerson)
			{
				return this;
			}
			return null;
		}
		public override string ToString()
		{
			string str = organizationName + " ";
			str += contactPerson + " ";
			str += address + " ";
			str += phoneNumber + " ";
			str += fax + " ";
			return str;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{ 
			//Вывод информации
			string path = "data.txt";
			SaveInFile(path);
			TelephoneDirectory[] telephoneDirectories;
			ReadFromFile(path, out telephoneDirectories);
			foreach (TelephoneDirectory tD in telephoneDirectories)
			{
				Console.WriteLine(tD.OutputNote());
			}
			Console.WriteLine();
			foreach (TelephoneDirectory tD in telephoneDirectories)
			{
				if (tD.MatchByFamily("Георгиевский") != null)
				{
					Console.WriteLine(tD.OutputNote());
				}
			}
		}
		static void SaveInFile(string path) 
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
