using SIS_MODEL;
using System;

namespace SIS_DATA
{
    public class InMemoryPersonalInfo
    {
        public static void PersonalInfo1()
        {
            StudentInformation student1 = new StudentInformation("2021-0066-BN-0",
                "Stephen Mathew C. Perez",
                "Male",
                new DateTime(2002, 5, 9),
                "Bayambang",
                0908484440,
                "perezstephenmathew360@gmail.com",
                "Binan Laguna",
                "Platero Binan City Laguna");

            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("PERSONAL INFORMATION");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Student Number: " + student1.studentNumber);
            Console.WriteLine("Name: " + student1.Name);
            Console.WriteLine("Gender: " + student1.Gender);
            Console.WriteLine("Date of Birth: " + student1.DateofBirth);
            Console.WriteLine("Place of Birth: " + student1.placeofBirth);
            Console.WriteLine("Mobile Number: " + student1.mobileNo);
            Console.WriteLine("Email Address: " + student1.emailAddress);
            Console.WriteLine("Residential Address: " + student1.residentialAddress);
            Console.WriteLine("Permanent Address: " + student1.permanentAdress);
            Console.WriteLine("------------------------------------------------\n");
        }
        
    }
}