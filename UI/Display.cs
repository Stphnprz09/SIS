using System;
using RULES;
using MODEL;

namespace UI
{
	public class Display
	{
        //Main Display
        public static void studentMainDisplay()
        {
            Console.WriteLine("\n!!!Welcome to PUPHUB System!!!\n");
            Console.WriteLine(">> Please enter a number you want to choose");
            Console.WriteLine("[1] - Student Information");
            Console.WriteLine("[2] - Personal Information");
            Console.WriteLine("[3] - Course Description");
            Console.WriteLine("[4] - Log out");


            CommonCodes.userInput();
            CommonCodes.intChoices = Convert.ToInt32(Console.ReadLine());
            switch (CommonCodes.intChoices)
            {
                case 1: //student info
                    viewStudentInfo();
                    break;

                case 2: //personal info
                    viewMenuPersonalInfo();
                    break;

                case 3: //course description
                    
                    break;

                case 4: //log out
                    Console.WriteLine("\nSystem log out");
                    break;

            }
            
        }

        //Personal Information Choices
        public static void viewMenuPersonalInfo()
        {

            Console.WriteLine("\nPERSONAL INFORMATION\n");

            Console.WriteLine(">> Please enter a number you want to choose");
            Console.WriteLine("[1] - View Personal Information");
            Console.WriteLine("[2] - Edit Personal Information");
            Console.WriteLine("[3] - Go Back");

            CommonCodes.userInput();
            CommonCodes.intChoices = Convert.ToInt32(Console.ReadLine());
            switch (CommonCodes.intChoices)
            {
                case 1: //viewing
                    viewPersonalInfo();
                    break;

                case 2: //updating

                    break;

                case 3: //Return

                    break;
            }
        }

      

        public static void viewStudentInfo()
        {
            Student student = getCredentials.info.studentInfo[getCredentials.studentNumber];
            
            Console.WriteLine("\nSTUDENT INFORMATION\n");
            
            Console.WriteLine($"Name: {student.fullname}");
            Console.WriteLine($"Program: {student.program}");
            Console.WriteLine($"Year: {student.year}");
            Console.WriteLine($"Section {student.section}");
            Console.WriteLine($"Type: {student.type}");
        }

        public static void viewPersonalInfo()
        {
            PersonalInfo Person = getCredentials.person.personalInfo[getCredentials.studentNumber];
            
            Console.WriteLine("\nVIEW PERSONAL INFORMATION\n");
            
            Console.WriteLine($"Name: {Person.fullname}");
            Console.WriteLine($"Gender: {Person.Gender}");
            Console.WriteLine($"DOB: {Person.DateofBirth}");
            Console.WriteLine($"POB: {Person.placeofBirth}");
            Console.WriteLine($"Mobile Number: {Person.mobileNo}");
            Console.WriteLine($"Email: {Person.emailAddress}");
            Console.WriteLine($"Residential Address: {Person.residentialAddress}");
            Console.WriteLine($"Permanent Address: {Person.permanentAdress}");
           
        }
    }
}

