using System;

namespace SIS_UI
{
	public class StudentForm
	{
        public static string username;

        //Welcome Page
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

        //Interface when clicked Personal Information 
        public static int actionStudentPersonalInfo()
        {
            Console.WriteLine("\nPlease choose an action: ");
            Console.WriteLine("[0]Go Back");
            Console.WriteLine("[1]View Student Personal Information");
            Console.WriteLine("[2]Update Student Personal Information");
            Console.Write("Input: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        //Interface when updating an Personal Information
        //public static int actionUpdateStudentPersonalInfo()
        //{
        //    Console.WriteLine("\nCurrent personal information\n");
        //    PrintInfos.PrintStudentPersonalInfo(StudentForm.username);

        //    Console.WriteLine("\nEDIT PERSONAL INFORMATION\n");
        //    Console.WriteLine("Please choose an action: ");
        //    Console.WriteLine("[1] - Name");
        //    Console.WriteLine("[2] - Birthday");
        //    Console.WriteLine("[3] - SIS Account Number");
        //    Console.WriteLine("[4] - Date of Birth");
        //    Console.WriteLine("[5] - Place of Birth");
        //    Console.WriteLine("[6] - Mobile Number");
        //    Console.WriteLine("[7] - Email Address");
        //    Console.WriteLine("[8] - Residential Address");
        //    Console.WriteLine("[9] - Permanent Address");
        //    Console.Write("Input: ");
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        public static string getSISAcc()
        {
            Console.WriteLine("Enter the SIS account number of the student to verify changes:");
            return Console.ReadLine();
        }
        public static string updatePlaceOfBirth()
        {
            Console.WriteLine("Enter new Place Of Birth: ");
            return Console.ReadLine();
        }

        public static string updateEmailAddress()
        {
            Console.WriteLine("Enter new Email Address: ");
            return Console.ReadLine();
        }

        public static string updateResidentialAdd()
        {
            Console.WriteLine("Enter new Residential Address: ");
            return Console.ReadLine();
        }

        public static string updatePermanentAdd()
        {
            Console.WriteLine("Enter new Permanent Address: ");
            return Console.ReadLine();
        }

        public static long updateContactNumber()
        {
            Console.WriteLine("Enter new Contact Number: ");
            return Convert.ToInt64(Console.ReadLine());
        }

        //method to call success update
        public static void successUpdate()
        {
            Console.WriteLine("Student personal information updated successfully.");
        } 

        public static void nonEditable()
        {
            Console.WriteLine("This information is not editable");
        }

        public static void attendance()
        {
            Console.WriteLine("On progress of Nico's Group");
        }

        public static void gradingSystem()
        {
            Console.WriteLine("\nOn Progress of Rizon's Group\n");
        }

        public static void studentInformation()
        {

        }
    }
}

