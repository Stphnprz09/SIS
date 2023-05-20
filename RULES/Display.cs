using System;
using MODEL;

namespace RULES
{
	public class Display
	{
        public static void mainDisplay()
        {
            Console.WriteLine("\n!!!Welcome to PUPHUB System!!!\n");
            Console.WriteLine(">> Please enter a number you want to choose");
            Console.WriteLine("[1] - Student Information");
            Console.WriteLine("[2] - Personal Information");
            Console.WriteLine("[3] - Course Description");
            Console.WriteLine("[4] - Log out");


            CommonCodes.userInput();
        }

        public static void viewStudentInfo()
        {
            Student student = getCredentials.info.studentInfo[getCredentials.studentNumber];
            //Console.WriteLine($"\nWelcome {getCredentials.studentNumber}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("STUDENT INFORMATION");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Name: {student.fullName}");
            Console.WriteLine($"Program: {student.program}");
            Console.WriteLine($"Year: {student.year}");
            Console.WriteLine($"Section {student.section}");
            Console.WriteLine($"Type: {student.type}");
            Console.WriteLine("-----------------------------------------------------------");
        }

        public static void viewPersonalInfo()
        {
            PersonalInfo Person = getCredentials.person.personalInfo[getCredentials.studentNumber];
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("PERSONAL INFORMATION");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Name: {Person.fullName}");
            Console.WriteLine($"Gender: {Person.Gender}");
            Console.WriteLine($"DOB: {Person.DateofBirth}");
            Console.WriteLine($"POB: {Person.placeofBirth}");
            Console.WriteLine($"Mobile Number: {Person.mobileNo}");
            Console.WriteLine($"Email: {Person.emailAddress}");
            Console.WriteLine($"Residential Address: {Person.residentialAddress}");
            Console.WriteLine($"Permanent Address: {Person.permanentAdress}");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}

