using System;
using DATA;

namespace UI
{
	public class getCredentials
	{
        public static InMemoryInfo info = new InMemoryInfo();
		public static InMemoryPersonalnfo person = new InMemoryPersonalnfo();

		public static string studentNumber;

        public static void userStudentCredentials()
		{
			info.infos();
			//person.studentPersonalInfo();

            Console.Write("\nEnter your account number: ");
			studentNumber = Console.ReadLine();

			DisplayStudentSIS(studentNumber);
        }

		public static void DisplayStudentSIS(String studentNumber)
		{
			if (info.studentInfo.ContainsKey(studentNumber))
			{
				Console.WriteLine("\nSuccessful Login\n");
                Console.WriteLine($"Welcome {studentNumber}");
				CommonCodes.readKey();
				Display.studentMainDisplay();

				
            }
			else
			{
				Console.WriteLine("Incorrect credentials, please try again later");
			}
		}

	}
}

