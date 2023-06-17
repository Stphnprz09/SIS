using System;
namespace UI
{
	public class CommonCodes
	{
        public static int intChoices;
        public static char charChoices;

        public static void userInput()
        {
            Console.Write(">> input:");
        }

        public static void readKey()
        {
            Console.WriteLine("\n<please enter to continue>\n");
            Console.ReadKey();
        }

        public static void actionReturn(char commandOption)
        {
            Console.Write("\nDo you want to continue?[type any to continue/type N to end]\n");
            CommonCodes.userInput();
            commandOption = Convert.ToChar(Console.ReadLine());

            while (commandOption != 'N')
            {
                Display.studentMainDisplay();
                break;
            }
            Console.WriteLine("\nSystem end");

        }
    }
}

