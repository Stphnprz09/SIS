using System;
namespace SIS
{
	public class DisplayLayout
	{
		public void mainDisplay()
		{
			Console.WriteLine("!!!Welcome to PUPHUB System!!!\n");
			Console.WriteLine(">> Please enter a number you want to choose");
			Console.WriteLine("[1] - Profile");
			Console.WriteLine("[2] - Log Out\n");
		}

		public void userInput()
		{
            Console.Write(">> input:");
        }
	}
}

