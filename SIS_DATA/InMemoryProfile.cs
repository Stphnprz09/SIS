﻿using System;
using SIS_MODEL;
namespace SIS_DATA
{
	public class Student
	{
     
        public static void profile1()
        {
            StudentInfo student1 = new StudentInfo("Stephen Mathew C. Perez", "BSIT", 2, 1, "2021-00066-BN-0");

            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("STUDENT PROFILE");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Full Name: " + student1.fullName);
            Console.WriteLine("Course: " + student1.program);
            Console.WriteLine("Year: " + student1.year);
            Console.WriteLine("Section: " + student1.section);
            Console.WriteLine("Student Number: " + student1.studentNumber);
            Console.WriteLine("------------------------------------------------\n");
        }
    }
}

