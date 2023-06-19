using System;

namespace SIS_UI
{
	public class StudentForm
	{
        public static string username;

        public static int studentWelcomePage()
		{
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Log out");
            Console.WriteLine("[1]Student Information");
            Console.WriteLine("[2]Personal Information");
            Console.WriteLine("[3]Grading System");
            Console.WriteLine("[4]Attendance");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int actionStudentPersonalInfo()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Go Back");
            Console.WriteLine("[1]View Student Personal Information");
            Console.WriteLine("[2]Update Student Personal Information");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void attendance()
        {
            Console.WriteLine("On progress of Nico's Group");
        }

        public static void gradingSystem()
        {
            Console.WriteLine("On Progress of Rizon's Group");
        }

        public static void studentInformation()
        {

        }
    }
}

