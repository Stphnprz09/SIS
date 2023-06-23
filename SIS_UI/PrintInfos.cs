using System;
using SIS_MODEL;
using SIS_DATA;

namespace SIS_UI
{
	public class PrintInfos
	{
        public static void PrintStudentInfo(string sisAccountNumber)
        {
            InMemoryStudentInfo studentInfo = new InMemoryStudentInfo();
            StudentInfo student = studentInfo.GetStudentInfoBySISAccountNumber(sisAccountNumber);

            if (student != null)
            {
                Console.WriteLine("\nStudent Information:\n");
                Console.WriteLine($"SIS Account Number: {student.SISAccountNumber}");
                Console.WriteLine($"Full Name: {student.fullName}");
                Console.WriteLine($"Course: {student.course}");
                Console.WriteLine($"Year: {student.year}");
                Console.WriteLine($"Section: {student.section}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public static void PrintStudentPersonalInfo(string sisAccountNumber)
        {
            InMemoryStudentPersonalInfo personalinfo = new InMemoryStudentPersonalInfo();
            StudentPersonalInfo personal = personalinfo.GetStudentPersonalInfoBySISAccountNumber(sisAccountNumber);

            if (personal != null)
            {
                Console.WriteLine("\nStudent Personal Information:\n");
                Console.WriteLine($"SIS Account Number: {personal.SISAccountNumber}");
                Console.WriteLine($"Full Name: {personal.fullname}");
                Console.WriteLine($"Gender: {personal.Gender}");
                Console.WriteLine($"Date of Birth: {personal.DateofBirth}");
                Console.WriteLine($"Place of Birth: {personal.placeofBirth}");
                Console.WriteLine($"Mobile Number: {personal.mobileNo}");
                Console.WriteLine($"Email Address: {personal.emailAddress}");
                Console.WriteLine($"Residential Address: {personal.residentialAddress}");
                Console.WriteLine($"Permanent Address: {personal.permanentAdress}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

        }

        

    }
}

