using System;

namespace CSharpFundamentals
{
	public class Person
	{
		public string FirstName;
		public string LastName;
		
		public void Introduce()
		{
			Console.WriteLine("My name is " + FirstName + "" + LastName);
		}
	}
	
	class Program
	{
		static void Main(string[] args)
		{
			//Person john = new Person();
			var john = new Person();
			john.FirstName = "John";
			john.LastName = "Smith";
			john.Introduce;
		}	
	}
}
