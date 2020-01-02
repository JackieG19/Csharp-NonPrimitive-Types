using System;

namespace CSharpFundamentals
{	
	class Program
	{
		static void Main(string[] args)
		{
			var names = new string[3] {"John", "Jack", "Mary"};
			
			var formattedNames = string.Join(",", names);
			/*string.Join method - The string.Join method combines many strings 
			into one. It receives two arguments: an array and a separator string.*/

			Console.WriteLine(formattedNames);
		}	
	}
}
