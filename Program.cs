using System;

namespace CS_scratchpad
{
	 class Program
	 {
		  static void Main(string[] args)
		  {
				Console.WriteLine("This is a scratchpad C# .NET 5 app, mainly to play around with GitKraken.");
				Console.WriteLine("This adds Message Two.");
				Console.WriteLine("This adds Message 3.");
				Console.WriteLine("This should be the last-added message in all circumstances.");

				TestMethod();
		  }

		  static void TestMethod()
		  {
				if (true)
				{
					 Console.WriteLine("This line should be printed");
					 return;
				}

				Console.WriteLine("This line shouldn't be printed");
		  }
	 }
}
