using System;
namespace SIS_UI
{
	public class FacultyForm
	{
        public static int facultyWelcomePage()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Log out");
            Console.WriteLine("[1]Faculty Information");
            //Console.WriteLine("[2]Personal Information");
            Console.WriteLine("[3]Grading System");
            Console.WriteLine("[4]Attendance");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

