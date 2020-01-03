using System;

namespace CSharpFundamentals
{	
	class Program
	{
		static void Main(string[] args)
		{
			var firstName = "Mosh";
			var lastName = "Hamedani";
			
			var fullName = firstName + " " + lastName; // concatenate strings
			
			var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
			
			/*string.Format method - Converts the value of objects to strings based 
			on the formats specified and inserts them into another string.*/
		}	
	}
}
