using System;
using System.Collections.Generic;
using System.Text;

namespace Z13_Console
{
	abstract class TelephoneDirectory
	{
		public abstract string OutputNote();
		public abstract TelephoneDirectory MatchByFamily(string family);
	}
	class Person : TelephoneDirectory
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
}
