using System;
using DATA;
using MODEL;

namespace RULES
{
	public class getCredentials
	{
        public static InMemoryInfo info = new InMemoryInfo();
		public static InMemoryPersonalnfo person = new InMemoryPersonalnfo();

		public static string studentNumber;

        public static void userCredentials()
		{
			info.infos();
			person.studentPersonalInfo();

            Console.Write("\nEnter your account number: ");
			studentNumber = Console.ReadLine();

			DisplaySIS(studentNumber);
        }

		public static void DisplaySIS(String studentNumber)
		{
			if (info.studentInfo.ContainsKey(studentNumber))
			{
				Console.WriteLine("\nSuccessful Login\n");
                Console.WriteLine($"Welcome {studentNumber}");
                CommonCodes.readKey();
				Display.mainDisplay();
				ActionDisplay.actionMainDisplay();
            }
			else
			{
				Console.WriteLine("Incorrect credentials, please try again later");
			}
		}

	}
}

