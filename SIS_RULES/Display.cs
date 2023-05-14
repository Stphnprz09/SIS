using System;
namespace SIS_RULES
{
	public class Display
	{
        public static void mainDisplay()
        {
            Console.WriteLine("\n!!!Welcome to PUPHUB System!!!\n");
            Console.WriteLine(">> Please enter a number you want to choose");
            Console.WriteLine("[1] - Profile");
            Console.WriteLine("[2] - Log Out\n");

            CommonCodes.userInput();
        }

        public static void profileDisplay()
        {
            Console.WriteLine(">> Please enter a number you want to choose");
            Console.WriteLine("[1] - Other Information");
            Console.WriteLine("[2] - Course Description");
            Console.WriteLine("[3] - Go back");

            CommonCodes.userInput();
        }
    }
}

