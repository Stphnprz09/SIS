using System;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace SIS
{
	public class DisplayLayout
	{
		public static void mainDisplay()
		{
			Console.WriteLine("\n!!!Welcome to PUPHUB System!!!\n");
			Console.WriteLine(">> Please enter a number you want to choose");
			Console.WriteLine("[1] - Profile");
			Console.WriteLine("[2] - Log Out\n");
			//userInput();
		}

		public static void profileDisplay()
		{
			Console.WriteLine("\n>> Please enter a number you want to choose");
			Console.WriteLine("[1] - Other Information");
            Console.WriteLine("[2] - Course Description");
			Console.WriteLine("[3] - Go back");

			CommandFunction.actionProfileDisplay();
        }

		public static void userInput()
		{
			Console.Write(">> input:");
		}

		public static void viewProfile()
		{
			UserProfile user1 = new UserProfile("dummy user 1", "BSIT", 2, 1, "2021-00000-BN-0");

			Console.WriteLine("\n!!!Welcome to Profile!!!");
			readKey();
			Console.WriteLine("Here's your profile " + user1.fullName + "\n");
            Console.WriteLine("Name: " + user1.fullName);
            Console.WriteLine("Program: " + user1.program);
            Console.WriteLine("Year: " + user1.year);
            Console.WriteLine("Section: " + user1.section);
            Console.WriteLine("Student Number: " + user1.studentNumber);

			profileDisplay();
        }

		public static void readKey()
		{
            Console.WriteLine("<please enter to continue>\n");
            Console.ReadKey();
        }
	}
}

