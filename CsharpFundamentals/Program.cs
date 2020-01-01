using System;

namespace CSharpFundamentals
{	
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
			var result = calculator.Add(1, 2);
			Console.WriteLine(result);
		}	
	}
}
