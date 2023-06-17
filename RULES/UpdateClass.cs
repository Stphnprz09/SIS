//using System;
//using MODEL;
//namespace RULES
//{
//    public class UpdateClass
//    {
//        PersonalInfo Person = getCredentials.person.personalInfo[getCredentials.studentNumber];

//        public static void editPersonalInfo()
//        {
//            PersonalInfo Person = getCredentials.person.personalInfo[getCredentials.studentNumber];

//            Console.WriteLine("-----------------------------------------------------------");
//            Console.WriteLine("EDIT PERSONAL INFORMATION");
//            Console.WriteLine("-----------------------------------------------------------");
//            Console.Write("Enter Name: ");
//            Person.fullName = Console.ReadLine();
//            Console.Write("Enter Gender: ");
//            Person.Gender = Console.ReadLine();
//            //Console.Write("Enter Date of Birth: ");
//            //Person.DateofBirth = Console.ReadLine();
//            Console.Write("Enter Place of Birth: ");
//            Person.placeofBirth = Console.ReadLine();
//            Console.Write("Enter Mobile Number: ");
//            Person.mobileNo = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Enter Email Address: ");
//            Person.emailAddress = Console.ReadLine();
//            Console.Write("Enter Residential Address: ");
//            Person.residentialAddress = Console.ReadLine();
//            Console.Write("Enter Permanent Address: ");
//            Person.permanentAdress = Console.ReadLine();
//            Console.WriteLine("-----------------------------------------------------------");
//            Console.WriteLine("Information updated successfully.");
//            Display.viewMenuPersonalInfo();

//            Console.WriteLine("\nCurrent personal information\n");
//            Display.viewPersonalInfo();

//            Console.WriteLine("\n-----------------------------------------------------------");
//            Console.WriteLine("EDIT PERSONAL INFORMATION");
//            Console.WriteLine("-----------------------------------------------------------");
//            Console.WriteLine("[1] - Date of Birth");
//            Console.WriteLine("[2] - Place of Birth");
//            Console.WriteLine("[3] - Mobile Number");
//            Console.WriteLine("[4] - Email Address");
//            Console.WriteLine("[5] - Residential Address");
//            Console.WriteLine("[6] - Permanent Address");
//            Console.WriteLine("-----------------------------------------------------------");
//            Console.WriteLine("Enter the number of information you want to update: ");
//            ActionDisplay.choices = Convert.ToInt32(Console.ReadLine());

//            switch (ActionDisplay.choices)
//            {
//                case 1:
//                    Console.WriteLine("Enter updated date of birth");
//                    Person.DateofBirth = Convert.ToDateTime(Console.ReadLine());
//                    break;

//                case 2:
//                    Console.WriteLine("Enter updated place of birth");
//                    Person.placeofBirth = Console.ReadLine();
//                    break;

//                case 3:
//                    Console.Write("Enter updated mobile number");
//                    Person.mobileNo = Convert.ToInt32(Console.ReadLine());
//                    break;

//                case 4:
//                    Console.Write("Enter updated email address");
//                    Person.emailAddress = Console.ReadLine();
//                    break;

//                case 5:
//                    Console.Write("Enter updated residential address");
//                    Person.residentialAddress = Console.ReadLine();
//                    break;

//                case 6:
//                    Console.Write("Enter updated permanent address");
//                    Person.permanentAdress = Console.ReadLine();
//                    break;

//                    //Console.WriteLine("Information updated successfully.");
//            }

//            Console.WriteLine($"Choice number {ActionDisplay.choices} has been updated");
//            Display.viewMenuPersonalInfo();
//        }
//    }
//}

