using System;

namespace CSharpFundamentals
{	
	class Program
	{
		static void Main(string[] args)
		{
			// \n - means newline
			var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
			Console.WriteLine(text);
			
			var text2 = @"Hi John
			Look into the following paths
			c:\folder1\folder2\
			c:\folder3\folder4";
			
			Console.WriteLine(text2);
		}	
	}
}
